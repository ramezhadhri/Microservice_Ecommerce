using PanierService.Data;
using PanierService.Models;
using RestSharp;

namespace PanierService.Services
{
    public class PanierService:IPanierService
    {
        protected readonly DbcontextClass dbcontextClass; 

        public PanierService(DbcontextClass dbcontextClass)
        {
            this.dbcontextClass = dbcontextClass;
        }
        public void AddToCart(ProductCard productCard)
        {
            string apiURL = "";
            var client = new RestClient(apiURL);
            var request = new RestRequest(apiURL);
            var response=client.ExecuteGet(request);
            if (response.IsSuccessful)
            {
                Console.WriteLine ($"response {response.StatusCode} {response.StatusDescription}");


            }
        }

       
    }
}
