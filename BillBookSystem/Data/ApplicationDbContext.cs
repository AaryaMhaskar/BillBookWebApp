using BillBookSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BillBookSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Inventory> inven { get; set; }
        public DbSet<Invoiced> invo { get; set; }
        public DbSet<sale> sale { get; set; }
        public DbSet<SalesDetails> salesdetails { get; set; }
       
    }
}
