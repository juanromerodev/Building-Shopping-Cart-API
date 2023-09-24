using Microsoft.AspNetCore.Mvc;
using APIShoppingCart.Models;
using APIShoppingCart.Repositories;
using ApiShoppingCart.Repositories;

namespace ApiShoppingCart.Controllers

{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartController : ControllerBase
    {
        public ICartRepository cartRepository;
        public CartController(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        [HttpPost]
        [Route("/PlaceOrder")]
        public async Task<bool> PlaceOrder(Order order)
        {
            return await cartRepository.PlaceOrder(order);
        }

        [HttpGet]
        [Route("/GetOrders")]
        public async Task<IEnumerable<Order>> GetCustomers()
        {
            return await cartRepository.GetOrders();
        }
    }
}