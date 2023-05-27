using React_App.Models;
using System.Text.Json;

namespace React_App.Services
{
    /// <summary>
    /// Service in change to handle de request to get the product data
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Method to get all products
        /// </summary>
        /// <returns>A list of products with the data requested</returns>
        public async Task<IEnumerable<Product>?> GetAllProducts()
        {
            var uri = $"{_httpClient.BaseAddress}products/all";
            var response = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
            IEnumerable<Product>? products = new List<Product>()
            {
                new Product()
                {
                    Id = "P1",
                    Name = "Piña",
                    Price = 2000,
                    Thumbnail = "test"
                },
                new Product
                {
                    Id = "P2",
                    Name = "Manzana",
                    Price = 1000,
                    Thumbnail = "test"
                },
                new Product()
                {
                    Id = "P3",
                    Name = "Naranja",
                    Price = 500,
                    Thumbnail = "test"
                },
                new Product()
                {
                    Id = "P4",
                    Name = "Melón",
                    Price = 1500,
                    Thumbnail = "test"
                },
            };

            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                products = await JsonSerializer.DeserializeAsync<IEnumerable<Product>>(contentStream, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                return products;
            }

            return products;
        }
    }
}
