using React_App.Models;

namespace React_App.Services
{
    /// <summary>
    /// Service in change to handle de request to get the product data
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Method to get all products
        /// </summary>
        /// <returns>A list of products with the data requested</returns>
        Task<IEnumerable<Product?>> GetAllProducts(string listName);
    }
}
