using Microsoft.EntityFrameworkCore;
using PF_TinyCRM.Model;

namespace PF_TinyCRM.Data
{
    class CrmDbContext : DbContext
    {
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderProduct> OrderProducts { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog= PF_TinyCrm; Integrated Security = true");
        }
    }
}
