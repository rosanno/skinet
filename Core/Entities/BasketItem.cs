namespace Core.Entities
{
    public class BasketItem
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string pictureUrl { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}