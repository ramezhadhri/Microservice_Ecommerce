using Microsoft.EntityFrameworkCore;
using ProductService.Data;
using ProductService.Models;


namespace ProductService.Services
{
    public class ProductServicee:IProductService
    {
        private readonly DbContextClass _dbContextClass;
       public ProductServicee (DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public IEnumerable<Product> ProductList()
        {
           return _dbContextClass.Products.ToList();
        }
        public Product GetProductById(int id) {
            return _dbContextClass.Products.Where(x => x.ProductId == id).FirstOrDefault();
        }
        public Product GetProductByName(string name) {
            return _dbContextClass.Products.Where(x => x.ProductName == name).FirstOrDefault();
        }
        public Product AddProduct(Product product) {
            product.DiscountedPrice = product.SellPrice - (product.SellPrice * (decimal)(product.DiscountPercentage / 100));
            var res=_dbContextClass.Products.Add(product);
            _dbContextClass.SaveChanges();
            return res.Entity;
        }
        public Product UpdateProduct(Product product) {
            product.DiscountedPrice = product.SellPrice - (product.SellPrice * (decimal)(product.DiscountPercentage / 100));
            var res = _dbContextClass.Products.Update(product);
            _dbContextClass.SaveChanges();
            return res.Entity;
        }

        public bool DeleteProduct(int id) {
            var res = _dbContextClass.Products.Where(x => x.ProductId == id).FirstOrDefault();
            _dbContextClass.Products.Remove(res);
            _dbContextClass.SaveChanges();
            return res != null ? true : false;
        }
        public Product AddToStock(int productId, int amount)
        {
            var product = _dbContextClass.Products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null && amount > 0)
            {
                product.ProductStock += amount;
               
                _dbContextClass.SaveChanges();
            }
            return product;
        }

        public Product SellProduct(int productId, int amount)
        {
            var product = _dbContextClass.Products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null && amount > 0 && product.ProductStock >= amount)
            {
                product.ProductStock -= amount;
                _dbContextClass.SaveChanges();
            }
            return product;
        }
       


    }
}
