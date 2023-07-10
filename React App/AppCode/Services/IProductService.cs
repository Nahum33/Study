using React_App.AppCode.Components.Product.Models;

namespace React_App.AppCode.Services
{
    /// <summary>
    /// Service in change to handle de request to get the product data
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Retrieves a list of products based on the specified product filters.
        /// </summary>
        /// <param name="filters">The filters of the product to search for. Leave all properties empty to retrieve default filter products.</param>
        /// <returns>A list of products that match the specified criteria.</returns>
        Task<IEnumerable<Product>?> GetProductsByCategoryAndNameAsync(ProductFiltersModel filters);
    }
}
