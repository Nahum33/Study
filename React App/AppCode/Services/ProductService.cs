using Microsoft.AspNetCore.DataProtection.KeyManagement;
using React_App.AppCode.Components.Product.Commands;
using React_App.AppCode.Components.Product.Factories;
using React_App.AppCode.Components.Product.Models;
using React_App.AppCode.Interfaces;
using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace React_App.AppCode.Services
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
        /// Retrieves a list of products based on the specified product filters.
        /// </summary>
        /// <param name="filters">The filters of the product to search for. Leave all properties empty to retrieve top 10 products.</param>
        /// <returns>A list of products that match the specified criteria.</returns>
        public async Task<IEnumerable<Product>?> GetProductsByCategoryAndNameAsync(ProductFiltersModel filters)
        {
            var products = Enumerable.Empty<Product>();

            var uri = $"{_httpClient.BaseAddress}endpoint/products/all";
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.Add("api-key", "8G7zW1kv2SCHeEyT7MWGRrXw2IO3fv6q34WAHEjNeHSyMwsFKRw4yPDuStf3nJZ1");

            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                var result = await JsonSerializer.DeserializeAsync<IEnumerable<Product>>(contentStream, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                products = result;
            }

            // Filter Order Rules
            var filter = new ProductFilterFactory(filters).Create();

            // Filters and Source config to the command
            var applyFilterCommand = new ApplyProductFilterCommand(filter, products);

            // Execute the filter command in the source
            applyFilterCommand.Execute();

            // Get Filtered Product after execute the command
            var filteredProducts = applyFilterCommand.GetExecutionResult();

            return filteredProducts;
        }
    }
}
