using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PanierService
{
    public class ProductResponse
    {

        
        public int ProductId { get; set; }

        
        public string ProductName { get; set; }

        
        public string ProductDescription { get; set; }

       
        public decimal BuyPrice { get; set; }
   
        public double DiscountPercentage { get; set; }

        public decimal DiscountedPrice { get; set; }

        
        public decimal SellPrice { get; set; }

        
        public int ProductStock { get; set; }

        public int CategoryId { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } 

    }
}
