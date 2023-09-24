using APIShoppingCart.Models;

namespace APIShoppingCart.Repositories
{
    public interface ICartRepository
    {
        public Task<bool> PlaceOrder(Order order);
    }
}
