using React_App.AppCode.Components.Product.Commands;
using React_App.AppCode.Components.Product.Factories;
using React_App.AppCode.Components.Product.Models;
using React_App.AppCode.Interfaces;

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
            // This lines is to add later DDD design pattern
            var uri = $"{_httpClient.BaseAddress}products/all";
            var response = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                return null;
            }

            // Get Products from the source
            var products = GetProducts();

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

        /// <summary>
        /// Temporal method to get the product list
        /// </summary>
        /// <returns>Product list</returns>
        private IEnumerable<Product>? GetProducts()
        {
            IEnumerable<Product>? products = new List<Product>()
            {
                // Verduras
                new Product()
                {
                    Id = "V001",
                    Name = "PAPA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V002",
                    Name = "REPOLLO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V003",
                    Name = "TOMATE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V004",
                    Name = "ZANAHORIA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V005",
                    Name = "YUCA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V006",
                    Name = "CHILE DULCE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V007",
                    Name = "CAMOTE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V008",
                    Name = "CEBOLLA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V009",
                    Name = "CEBOLLA MORADA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V010",
                    Name = "REPOLLO MORADO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V011",
                    Name = "LECHUGA",
                    Price = 1500,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V012",
                    Name = "AJÍ",
                    Price = 1000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                new Product()
                {
                    Id = "V013",
                    Name = "ESPÁRRAGOS",
                    Price = 3000,
                    Thumbnail = "test",
                    Category = "VERDURA"
                },
                // ... Añade más verduras aquí

                // Frutas
                new Product()
                {
                    Id = "F001",
                    Name = "MANZANA",
                    Price = 250,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F002",
                    Name = "NARANJA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F003",
                    Name = "UVA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F004",
                    Name = "UVA VERDE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F005",
                    Name = "PERA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F006",
                    Name = "GUAYABA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F007",
                    Name = "MANDARINA",
                    Price = 3000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F008",
                    Name = "FRESAS",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F009",
                    Name = "MANGO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F010",
                    Name = "SANDIA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F011",
                    Name = "PLÁTANO",
                    Price = 1500,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F012",
                    Name = "KIWI",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                new Product()
                {
                    Id = "F013",
                    Name = "MELÓN",
                    Price = 2500,
                    Thumbnail = "test",
                    Category = "FRUTA"
                },
                // ... Añade más frutas aquí

                // Hortalizas
                new Product()
                {
                    Id = "H001",
                    Name = "CEBOLLINO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "HORTALIZA"
                },
                new Product()
                {
                    Id = "H002",
                    Name = "CULANTRO CASTILLA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "HORTALIZA"
                },
                new Product()
                {
                    Id = "H003",
                    Name = "TOMILLO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "HORTALIZA"
                },
                new Product()
                {
                    Id = "H004",
                    Name = "PIMIENTO",
                    Price = 1500,
                    Thumbnail = "test",
                    Category = "HORTALIZA"
                },
                new Product()
                {
                    Id = "H005",
                    Name = "BERENJENA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "HORTALIZA"
                },
                // ... Añade más hortalizas aquí

                // Varios
                new Product()
                {
                    Id = "B001",
                    Name = "QUESO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "OTRO"
                },
                new Product()
                {
                    Id = "B002",
                    Name = "HUEVOS",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "OTRO"
                },
                new Product()
                {
                    Id = "B003",
                    Name = "COCO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category = "OTRO"
                },
                new Product()
                {
                    Id = "B004",
                    Name = "MIEL",
                    Price = 3000,
                    Thumbnail = "test",
                    Category = "OTRO"
                },
                new Product()
                {
                    Id = "B005",
                    Name = "ACEITE DE OLIVA",
                    Price = 5000,
                    Thumbnail = "test",
                    Category = "OTRO"
                },
            };

            return products;
        }
    }
}
