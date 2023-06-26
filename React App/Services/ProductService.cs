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
        public async Task<IEnumerable<Product?>> GetAllProducts(string listName)
        {
            var uri = $"{_httpClient.BaseAddress}products/all";
            var response = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);

            IEnumerable<Product?> verduras = new List<Product?>()
            {
                new Product()
                {
                    Id = "V001",
                    Name = "PAPA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V002",
                    Name = "REPOLLO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V003",
                    Name = "TOMATE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V004",
                    Name = "ZANAHORIA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V005",
                    Name = "YUCA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V006",
                    Name = "CHILE DULCE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V007",
                    Name = "CAMOTE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V008",
                    Name = "CEBOLLA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V009",
                    Name = "CEBOLLA MORADA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                },
                new Product()
                {
                    Id = "V010",
                    Name = "REPOLLO MORADO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VERDURA"
                }
            };

            IEnumerable<Product?> frutas = new List<Product?>()
            {
                new Product()
                {
                    Id = "F001",
                    Name = "MANZANA",
                    Price = 250,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F002",
                    Name = "NARANJA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F003",
                    Name = "UVA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F004",
                    Name = "UVA VERDE",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F005",
                    Name = "PERA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F006",
                    Name = "GUAYABA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F007",
                    Name = "MANDARINA",
                    Price = 3000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F008",
                    Name = "FRESAS",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F009",
                    Name = "MANGO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                },
                new Product()
                {
                    Id = "F010",
                    Name = "SANDIA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="FRUTA"
                }
            };

            IEnumerable<Product?> hortalizas = new List<Product?>()
            {
                new Product()
                {
                    Id = "H001",
                    Name = "CEBOLLINO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="HORTALIZA"
                },
                new Product()
                {
                    Id = "H002",
                    Name = "CULANTRO CASTILLA",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="HORTALIZA"
                },
                new Product()
                {
                    Id = "H003",
                    Name = "TOMILLO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="HORTALIZA"
                }
            };

            IEnumerable<Product?> varios = new List<Product?>()
            {
                new Product()
                {
                    Id = "B001",
                    Name = "QUESO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VARIOS"
                },
                new Product()
                {
                    Id = "B002",
                    Name = "HUEVOS",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VARIOS"
                },
                new Product()
                {
                    Id = "B003",
                    Name = "COCO",
                    Price = 2000,
                    Thumbnail = "test",
                    Category="VARIOS"
                }
            };

            Dictionary<string, IEnumerable<Product?>> productListDictionary = new Dictionary<string, IEnumerable<Product?>>()
            {
                { "Verduras", verduras },
                { "Frutas", frutas },
                { "Hortalizas", hortalizas },
                { "Varios", varios }
            };

            IEnumerable<Product?> combinedList = productListDictionary.Values.SelectMany(list => list.Take(2)).ToList<Product?>();
            productListDictionary.Add("loMasVendido", combinedList);

            IEnumerable<Product?> products = productListDictionary[listName] ?? Enumerable.Empty<Product?>();

            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                return products;
            }

            return products;
        }
    }
}
