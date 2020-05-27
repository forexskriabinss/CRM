
using System.Data.Entity;

namespace CRM.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext():base(@"Server=LAPTOP-4DO15LPF\SQLEXPRESS;Database=MyDb;Trusted_Connection=True;")
        {
        }

        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sell> Sells { get; set; }

    }
}
