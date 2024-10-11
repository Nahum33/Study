using Microsoft.AspNetCore.Mvc;
using React_App.AppCode.Commands.Models;
using React_App.Services;

namespace React_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : Controller
    {
        private readonly ITradeService _tradeService;
        private readonly IServiceService _serviceService;

        /// <summary>
        /// Example Controller to handle request from client searches.
        /// </summary>
        /// <param name="tradeService"> injection trades service</param>
        /// <param name="serviceService"> injection services service</param>
        public SearchController(ITradeService tradeService, IServiceService serviceService)
        {
            _tradeService = tradeService;
            _serviceService = serviceService;
        }

        /// <summary>
        /// GET Method to retrieve the products filtered.
        /// </summary>
        /// <param name="searchCommand">The filters of the listings to search for. Leave all properties empty to retrieve top 10 listings.</param>
        /// <returns>A response in API format.</returns>
        [HttpGet]
        [Route("GetResults")]
        public async Task<IResult?> GetResultsAsync([FromQuery] SearchCommand searchCommand)
        {
            var trades = _tradeService.GetTradesAsync(searchCommand);
            var services = _serviceService.GetServicesAsync(searchCommand);

            await Task.WhenAll(trades, services).ConfigureAwait(false);

            var products = services.Result;

            return products is not null
                ? Results.Ok(new { products = products })
                : Results.NotFound(new { message = "NOT_PRODUCTS_AVAILABLE" });
        }
    }
}
