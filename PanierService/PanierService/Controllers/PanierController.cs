using Microsoft.AspNetCore.Mvc;
using PanierService.Models;
using PanierService.Services;

namespace PanierService.Controllers
{
    [Route("api/[controller]")]
    public class PanierController:ControllerBase
    {
       protected readonly IPanierService panierService;
        public PanierController(IPanierService panierService)
        {
            this.panierService = panierService;
        }
       
        [HttpPost("AddItem")]
        public void AddItem()
        {
            panierService.AddToCart();
        }


    }
}
