using Microsoft.AspNetCore.Mvc;
using React_App.AppCode.ProductFilters;
using React_App.AppCode.Services;

namespace React_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        /// <summary>
        /// Example Controller to handle request from home component.
        /// </summary>
        /// <param name="productService"> injection product service</param>
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// GET Method to retrieve the products filtered.
        /// </summary>
        /// <param name="filters">The filters of the product to search for. Leave all properties empty to retrieve top 10 products.</param>
        /// <returns>A response in API format.</returns>
        [HttpGet]
        [Route("GetProducts")]
        public async Task<IResult?> GetProductsByCategoryAndNameAsync([FromQuery] ProductFiltersModel filters)
        {
            var products = await _productService.GetProductsByCategoryAndNameAsync(filters);

            return products is not null
                ? Results.Ok(new { products = products })
                : Results.NotFound(new { message = "NOT_PRODUCTS_AVAILABLE" });
        }
    }
}
