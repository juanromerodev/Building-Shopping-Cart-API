namespace APIShoppingCart.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Subtotal { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
