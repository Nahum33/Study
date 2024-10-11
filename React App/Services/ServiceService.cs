using System.Text.Json;
using React_App.AppCode.Commands.Concretes;
using React_App.AppCode.Commands.Models;
using React_App.AppCode.Models;
using React_App.Extensions;

namespace React_App.Services
{
    /// <summary>
    /// Service in change to handle de request to get the services data
    /// </summary>
    public class ServiceService : IServiceService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ServiceService> _logger;

        public ServiceService(HttpClient httpClient, IConfiguration configuration, ILogger<ServiceService> logger)
        {
            _configuration = configuration;
            _httpClient = httpClient;
            _apiUrl = $"{_httpClient.BaseAddress}endpoint/services";
            _logger = logger;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Service>?> GetServicesAsync(SearchCommand searchCommand)
        {
            try
            {
                var parameters = new GetSearchParametersCommand(searchCommand).Execute();
                var uri = new UriBuilder(_apiUrl) { Query = parameters.GetQueryStringParameters() };
                var request = new HttpRequestMessage(HttpMethod.Post, uri.Uri.AbsoluteUri);
                request.Headers.Add("Api-Key", _configuration["ApiKey"]);

                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = await response.Content.ReadAsStreamAsync();
                    var result = await JsonSerializer.DeserializeAsync<IEnumerable<Service>>(contentStream,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                    return result;
                }
            }
            catch (Exception)
            {
                _logger.LogError("Error when fetching services data");
            }

            return Enumerable.Empty<Service>();
        }
    }
}
