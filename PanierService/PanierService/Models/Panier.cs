using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PanierService.Models
{
    public class Panier
    {
        
        public List<ProductCard> ProductCards=new List<ProductCard>();
        public double TotalPrice() => ProductCards.Sum(ProductCard => ProductCard.totalProductPrice());
        public int ToatalQuantity()=> ProductCards.Sum(ProductCard => ProductCard.Quantity);
    }
}
