using React_App.AppCode.Models;

namespace React_App.AppCode.Interfaces
{
    /// <summary>
    /// Interface for product filters
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Applies the logic filter to the list of products.
        /// </summary>
        /// <param name="products"> Products List to filtered</param>
        /// <returns>The filtered list of products.</returns>
        IEnumerable<Product> Apply(IEnumerable<Product> products);
    }
}