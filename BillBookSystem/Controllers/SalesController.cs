using BillBookSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BillBookSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public SalesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet("GetBillWiseProfit")]
        public IActionResult GetBillWiseProfit()
        {
            var data = db.salesdetails.FromSqlRaw($"exec GetSalesDetails");
            return Ok(data);
        }


    }
}
