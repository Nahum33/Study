using React_App.AppCode.Commands.Models;
using React_App.AppCode.Models;

namespace React_App.Services
{
    /// <summary>
    /// Service in change to handle de request to get the services data
    /// </summary>
    public interface IServiceService
    {
        /// <summary>
        /// Retrieves a list of service based on the specified search command parameters.
        /// </summary>
        /// <param name="searchCommand">The search command parameters.</param>
        /// <returns>A list of service that match the specified criteria.</returns>
        Task<IEnumerable<Service>?> GetServicesAsync(SearchCommand searchCommand);
    }
}
