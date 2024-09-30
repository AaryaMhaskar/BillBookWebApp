using BillBookSystem.Migrations;
using BillBookSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BillBookSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Inventory> inven { get; set; }
        public DbSet<Invoiced> invoiced { get; set; }
        public DbSet<sale> sale { get; set; }
        public DbSet<SalesDetails> salesdetails { get; set; }
        public DbSet<Party> party { get; set; }
        public DbSet<SalesSummaryResult> salessummary { get; set; }
       public DbSet<Invoices> invoices { get; set; }
        public DbSet<Status> status { get; set; }
        public DbSet<BillWiseProfit> billwiseprofit { get; set; }
    }
}
