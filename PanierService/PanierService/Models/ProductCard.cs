namespace PanierService.Models
{
    public class ProductCard
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double totalProductPrice() => Price * Quantity;

    }
}
