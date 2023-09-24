using APIShoppingCart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace APIShoppingCart.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
