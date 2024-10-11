using React_App.AppCode.Commands.Models;
using React_App.AppCode.Models;

namespace React_App.Services
{
    /// <summary>
    /// Service in change to handle de request to get the trades data
    /// </summary>
    public interface ITradeService
    {
        /// <summary>
        /// Retrieves a list of trade based on the specified search command parameters.
        /// </summary>
        /// <param name="searchCommand">The search command parameters.</param>
        /// <returns>A list of trades that match the specified criteria.</returns>
        Task<IEnumerable<Trade>?> GetTradesAsync(SearchCommand searchCommand);
    }
}
