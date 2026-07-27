using System.Net;
using System.Net.Http.Json;
using OrderService.Models;

namespace OrderService.Services
{
    // Encapsulates all inter-service communication with ProductService.
    // BaseUrl comes from configuration (appsettings.json) rather than being
    // hardcoded — a simple stand-in for a real service-discovery lookup.
    public class ProductServiceClient
    {
        private readonly HttpClient _httpClient;

        public ProductServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductDto?> GetProductAsync(int productId)
        {
            var response = await _httpClient.GetAsync($"/api/products/{productId}");
            if (response.StatusCode == HttpStatusCode.NotFound) return null;

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductDto>();
        }

        public async Task<bool> ReserveStockAsync(int productId, int quantity)
        {
            var response = await _httpClient.PostAsync(
                $"/api/products/{productId}/reserve?quantity={quantity}", null);
            return response.IsSuccessStatusCode;
        }
    }
}
