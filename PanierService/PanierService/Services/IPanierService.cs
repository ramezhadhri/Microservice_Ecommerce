using PanierService.Models;

namespace PanierService.Services
{
    public interface IPanierService
    {
        public void AddToCart(ProductCard productCard);
    }
}
