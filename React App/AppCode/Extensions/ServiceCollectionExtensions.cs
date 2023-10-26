using React_App.AppCode.Services;

namespace React_App.AppCode.Extensions
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
            services.AddHttpClient<IProductService, ProductService>(config =>
            {
                // Injection of new HttpClient Instance with a new base url for the mongodb atlas
                config.BaseAddress = new Uri("https://us-east-1.aws.data.mongodb-api.com/app/data-shujj/");
            });

            return services;
        }
    }
}
