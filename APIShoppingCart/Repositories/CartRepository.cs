
using APIShoppingCart.DbContexts;
using APIShoppingCart.Models;
using APIShoppingCart.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiShoppingCart.Repositories
{
    public class CartRepository : ICartRepository
    {
        
        private AppDbContext dbContext;
        public CartRepository(AppDbContext dbContext)
        {
            //Dependencies inyection
            this.dbContext = dbContext;
        }

        //Add order 
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

        //Get Orders
        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await dbContext.Orders.ToListAsync();
        }


        //Get Order by Id
        public Task<Order> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        //Update Order
        public Task<Order> UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        //Delete Order
        public Task<bool> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }
    }

}