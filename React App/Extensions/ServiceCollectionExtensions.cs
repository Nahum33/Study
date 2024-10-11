using React_App.Services;

namespace React_App.Extensions
{
    /// <summary>
    /// Extension class to set inject new services to the collection services
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Method to add service by with a new httpClient
        /// </summary>
        /// <param name="services">services interface collection</param>
        /// <param name="configuration">configuration from appSettings</param>
        /// <returns></returns>
        public static IServiceCollection AddHttpClientServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<ITradeService, TradeService>(config =>
            {
                // Injection of new HttpClient Instance with a new base url for the mongodb atlas
                config.BaseAddress = new Uri(configuration["BaseUrl"]);
            });

            services.AddHttpClient<IServiceService, ServiceService>(config =>
            {
                // Injection of new HttpClient Instance with a new base url for the mongodb atlas
                config.BaseAddress = new Uri(configuration["BaseUrl"]);
            });

            return services;
        }
    }
}
