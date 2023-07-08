using React_App.AppCode.Models;
using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    /// <summary>
    /// Default filter for products.
    /// </summary>
    public class DefaultFilter : IFilter
    {
        public DefaultFilter() { }

        /// <summary>
        /// Applies the Default filter to the list of products.
        /// </summary>
        /// <param name="products">The list of products to filter.</param>
        /// <returns>The filtered list of products.</returns>
        public IEnumerable<Product> Apply(IEnumerable<Product> products)
        {
            Random random = new Random();
            return products.OrderBy(x => random.Next()).Take(10);
        }
    }
}