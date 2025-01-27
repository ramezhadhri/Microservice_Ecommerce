using Newtonsoft.Json;
using PanierService.Models;
using RestSharp;

namespace PanierService.Services
{
    public class PanierService : IPanierService
    {
        private readonly Panier _panier;

        // Use DI to inject the Panier instance
        public PanierService(Panier panier)
        {
            _panier = panier;
        }

        public void AddToCart()
        {
            string apiURL = "https://localhost:7088/api/Product/GetProductID?id=1";
            var client = new RestClient(apiURL);
            var request = new RestRequest(apiURL);
            var response = client.ExecuteGet(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine($"Response: {response.StatusCode} {response.StatusDescription}");

                // Deserialize the response to a ProductResponse object
                var product = JsonConvert.DeserializeObject<ProductResponse>(response.Content);

                if (product != null)
                {
                    Console.WriteLine("Product retrieved successfully!");

                    

                  
                  
                }
                else
                {
                    Console.WriteLine("Failed to deserialize the product response.");
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve product from API.");
            }
        }
    }
}
