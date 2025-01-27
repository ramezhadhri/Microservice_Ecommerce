using Newtonsoft.Json;
using PanierService.Models;
using RestSharp;
using PanierService.Models;
using Microsoft.IdentityModel.Tokens;

namespace PanierService.Services
{
    public class PanierService : IPanierService
    {
        private readonly Panier _panier;

        // Use DI to inject the Panier instance
        public PanierService(Panier panier)
        {
            this._panier = panier;
        }

        public void AddToCart(ProductCard productCard)
        {
            string apiURL = $"https://localhost:7088/api/Product/GetProductID?id={productCard.ProductId}";
            var client = new RestClient(apiURL);
            var request = new RestRequest(apiURL);
            var response = client.ExecuteGet(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine($"Response est: {response.StatusCode} {response.Content}");

                // Deserialize the response to a ProductResponse object
                var product = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductResponse>(response.Content);
                 var sum = 0;
                if (product != null)
                {
                    Console.WriteLine("Product retrieved successfully!");

                    if(product.ProductStock < productCard.Quantity)
                    {
                        Console.WriteLine("quantite pas valide ");
                    }
                    else
                    {
                        Console.WriteLine("quantite  valide ");
                        _panier.ProductCards.Add(productCard);
                        
                        if (!_panier.ProductCards.IsNullOrEmpty())
                        {
                            Console.WriteLine("produit est ajouté");
                            sum++;
                            

                            Console.WriteLine(_panier.TotalPrice());
                            Console.WriteLine(_panier.ToatalQuantity());
                            Console.WriteLine(sum);
                            Console.WriteLine(_panier.ProductCards.LastIndexOf(productCard));

                        }
                    }



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
