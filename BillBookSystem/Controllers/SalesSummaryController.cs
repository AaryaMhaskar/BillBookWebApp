using BillBookSystem.Data;
using BillBookSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BillBookSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesSummaryController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public SalesSummaryController(ApplicationDbContext db)
        {
            this.db = db;
        }

        private List<SalesSummaryResult> GetSalesData(DateTime startDate, DateTime endDate)
        {
            return db.salessummary
                .FromSqlRaw("EXEC GetSalesSummaryByDateRange @StartDate = {0}, @EndDate = {1}", startDate, endDate)
                .ToList();
        }

        [HttpGet("GetSalesSummary")]
        public IActionResult GetSalesSummary()
        {
            var data = db.salessummary.FromSqlRaw("EXEC GetSalesSummary").ToList();
            return Ok(data);
        }

        [Route("GetParty")]
        [HttpGet]
        public IActionResult GetPartyDropdown()
        {
            var data = db.party.FromSqlRaw("exec Fetchallparty");
            return Ok(data);
        }


        [Route("GetStatus")]
        [HttpGet]
        public IActionResult GetStatusDropdown()
        {
            var data = db.status.FromSqlRaw("exec FetchAllStatus");
            return Ok(data);
        }




        [HttpGet("GetSalesById/{partyId:int}")]
        public IActionResult GetSalesById(int partyId)
        {
            var salesSummary = db.salessummary
                .FromSqlRaw("EXEC GetSalesSummaryById @PartyId = {0}", partyId)
                .ToList();

            if (!salesSummary.Any())
            {
                return NotFound("No sales data found for the given Party ID.");
            }

            return Ok(salesSummary);
        }

        [HttpGet("GetSalesByStatus/{invoiceStatus}")]
        public IActionResult GetSalesByStatus(string invoiceStatus)
        {
            if (string.IsNullOrWhiteSpace(invoiceStatus))
            {
                return BadRequest("Invoice status must be provided.");
            }

            var salesSummary = db.salessummary
                .FromSqlRaw("EXEC GetSalesSummaryByStatus @InvoiceStatus = {0}", invoiceStatus)
                .ToList();

            if (!salesSummary.Any())
            {
                return NotFound("No sales data found for the given Invoice Status.");
            }

            return Ok(salesSummary);
        }

        [HttpGet("GetSalesByDateRange/{range}")]
        public IActionResult GetSalesByDateRange(string range)
        {
            DateTime startDate;
            DateTime endDate = DateTime.Now.Date.AddDays(1); // Include the whole current day

            switch (range.ToLower())
            {
                case "today":
                    startDate = DateTime.Today;
                    break;
                case "yesterday":
                    startDate = DateTime.Today.AddDays(-1);
                    endDate = startDate.AddDays(1);
                    break;
                case "this week":
                    startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                    break;
                case "last week":
                    startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek - 7).ToString("yyyy-MM-dd");
                    endDate = startDate.AddDays(7).ToString("yyyy-MM-dd");
                    break;
                case "last 7 days":
                    startDate = DateTime.Now.AddDays(-7);
                    break;
                case "this month":
                    startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    break;
                case "last month":
                    var lastMonth = DateTime.Today.AddMonths(-1);
                    startDate = new DateTime(lastMonth.Year, lastMonth.Month, 1);
                    endDate = startDate.AddMonths(1);
                    break;
                case "this quarter":
                    int currentQuarter = (DateTime.Today.Month - 1) / 3 + 1;
                    startDate = new DateTime(DateTime.Today.Year, (currentQuarter - 1) * 3 + 1, 1);
                    break;
                case "last quarter":
                    int lastQuarter = (DateTime.Today.Month - 1) / 3;
                    startDate = new DateTime(DateTime.Today.Year, (lastQuarter - 1) * 3 + 1, 1);
                    endDate = startDate.AddMonths(3);
                    break;
                case "current fiscal year":
                    startDate = new DateTime(DateTime.Today.Year, 4, 1); // Assuming fiscal year starts in April
                    break;
                case "previous fiscal year":
                    startDate = new DateTime(DateTime.Today.Year - 1, 4, 1); // Previous fiscal year
                    endDate = new DateTime(DateTime.Today.Year, 3, 31);
                    break;
                case "last 365 days":
                    startDate = DateTime.Now.AddDays(-365);
                    break;
                case "date range":
                    // You can implement handling for start and end dates here
                    return BadRequest("Please provide a valid date range.");
                default:
                    return BadRequest("Invalid range specified.");
            }

            // Log the date range for debugging
            Console.WriteLine($"Fetching sales data from {startDate} to {endDate}");

            var salesData = GetSalesData(startDate, endDate);

            if (!salesData.Any())
            {
                return NotFound("No sales data found for the given date range.");
            }

            return Ok(salesData);
        }

        [HttpGet("GetAllParties")]
        public IActionResult GetAllParties()
        {
            var parties = db.party.ToList();
            return Ok(parties);
        }

        [HttpGet("GetSalesByPartyId/{partyId:int}")]
        public IActionResult GetSalesByPartyId(int partyId)
        {
            var salesSummary = db.salessummary
                .FromSqlRaw("EXEC GetSalesSummaryById @PartyId = {0}", partyId)
                .ToList();

            if (!salesSummary.Any())
            {
                return NotFound("No sales data found for the given Party ID.");
            }

            return Ok(salesSummary);
        }

    }
}
