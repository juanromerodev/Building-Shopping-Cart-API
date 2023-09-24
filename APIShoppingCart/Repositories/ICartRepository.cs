using APIShoppingCart.Models;

namespace APIShoppingCart.Repositories
{
    public interface ICartRepository
    {
        public Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrderById(int id);
        public Task<bool> PlaceOrder(Order order);
        Task<Order> UpdateOrder(Order order);
        Task<bool> DeleteOrder(int id);
    }
}
