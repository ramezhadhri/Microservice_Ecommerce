using ProductService.Models;

namespace ProductService.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> ProductList();
        public Product GetProductById(int id);
        public Product GetProductByName(string name);
        public Product AddProduct(Product product);
        public Product UpdateProduct(Product product);
        public bool DeleteProduct(int id);
        public Product SellProduct(int productId, int amount);
        public Product AddToStock(int productId, int amount);
    }
}
