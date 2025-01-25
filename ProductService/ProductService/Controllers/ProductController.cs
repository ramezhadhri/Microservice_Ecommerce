using Microsoft.AspNetCore.Mvc;
using ProductService.Services;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GET_ALL")]
        public IEnumerable<Product> GET_ALL()
        {
            return _productService.ProductList();
        }
        [HttpGet("GetProductID")]
        public Product GetProductID(int id) { 
            return _productService.GetProductById(id);
        }
        [HttpGet("GetProductNAME")]
        public Product GetProductNAME(string name)
        {
            return _productService.GetProductByName(name);
        }
        [HttpPost("AddProduct")]
        public Product AddProduct(Product product) { 
          var res=  _productService.AddProduct(product);
            return res;
        }
        [HttpPut("UpdateProduct")]
        public Product UpdateProduct(Product product) {
            var res = _productService.UpdateProduct(product);
            return res;
        }
        [HttpDelete("DeleteProduct")]
        public bool DeleteProduct(int id) { 
            return _productService.DeleteProduct(id);
        }
        [HttpPost("AddToStock")]
        public Product AddToStock(int productID,int Amout) {
            return _productService.AddToStock(productID,Amout);
        }
        [HttpPost("SellProduct")]
        public Product SellProduct(int productID, int Amout)
        {
            return _productService.SellProduct(productID, Amout);
        }





    }
}
