using System.Net.Http.Json;
//Mis Models to use in the reposnse
using Inventory.Client.Modelos;

namespace Inventory.Client.Services
{
    public class StockService
    {
        private readonly HttpClient Elhttp;
        //TO use this in other page without calling again teh api to save respources
    public ApiResponse? LastResponse { get; private set; }

        public StockService(HttpClient http)
        {
            Elhttp = http;
        }
//bool forceRefresh = false so I can call fitst time as new, second call will refresh and save to usedata in other page
        public async Task<ApiResponse?> GetStockAsync(bool forceRefresh = false)
        {
            Console.WriteLine("Check-- Calling API to get Inventory...");
                if (LastResponse != null && !forceRefresh)
            return LastResponse;
            var result = await Elhttp.GetFromJsonAsync<ApiResponse>(
                "https://catchcoapi20251127143153.azurewebsites.net/api/ListProducts"
            );

            Console.WriteLine("Invenotry received");
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(result));
                    LastResponse = result;
            return result;
        }
    }
}
