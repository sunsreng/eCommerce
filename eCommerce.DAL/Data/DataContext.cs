using eCommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
