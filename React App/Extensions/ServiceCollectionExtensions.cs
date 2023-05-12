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
        /// <returns></returns>
        public static IServiceCollection AddHttpClientServices(this IServiceCollection services)
        {
            services.AddHttpClient<IUserService, UserService>(config =>
            {
                // Injection of new HttpClient Instance with a new base url for the UserService
                config.BaseAddress = new Uri("https://api.github.com");
            });

            return services;
        }
    }
}
