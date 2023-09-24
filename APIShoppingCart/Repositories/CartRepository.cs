
using APIShoppingCart.DbContexts;
using APIShoppingCart.Models;
using APIShoppingCart.Repositories;

namespace ApiShoppingCart.Repositories
{
    public class CartRepository : ICartRepository

    {

        private AppDbContext dbContext;

        public CartRepository(AppDbContext dbContext)

        {

            this.dbContext = dbContext;

        }



        public async Task<bool> PlaceOrder(Order order)

        {
            try
            {
                dbContext.Orders.Add(order);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                //grabar logs
                return false;

            }

        }

    }

}