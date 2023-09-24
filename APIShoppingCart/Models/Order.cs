namespace APIShoppingCart.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }

        public ICollection<OrderItem>? Items { get; set; }
    }
}
