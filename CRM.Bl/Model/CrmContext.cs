

using Microsoft.EntityFrameworkCore;

namespace CRM.Bl.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sell> Sells { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-4DO15LPF\SQLEXPRESS;Database=MyDb;Trusted_Connection=True;");
        }

    }
}
