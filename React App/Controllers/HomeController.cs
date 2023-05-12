using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using React_App.Services;

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
        /// GET Method to get the initial values for the home component
        /// </summary>
        /// <returns>response format API</returns>
        [HttpGet]
        [Route("GetInitialData")]
        public async Task<IResult?> GetInitialData()
        {
            var products = await _productService.GetAllProducts();

            return products is not null 
                ? Results.Ok(new { products = products })
                : Results.NotFound(new { message = $"Information not available at this moment" });
        }
    }
}
