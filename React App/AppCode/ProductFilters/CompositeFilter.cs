using React_App.AppCode.Interfaces;
using React_App.AppCode.Models;

namespace React_App.AppCode.ProductFilters
{
    /// <summary>
    /// Composite filter that combines multiple filters.
    /// </summary>
    public class CompositeFilter : IFilter
    {
        private readonly List<IFilter> _filters;

        public CompositeFilter()
        {
            _filters = new List<IFilter>();
        }

        /// <summary>
        /// Adds a filter to the composite filter.
        /// </summary>
        /// <param name="filter">The filter to add.</param>
        public void AddFilter(IFilter filter)
        {
            _filters.Add(filter);
        }

        /// <summary>
        /// Applies all the filters in sequence to the list of products.
        /// </summary>
        /// <param name="products">The list of products to filter.</param>
        /// <returns>The filtered list of products.</returns>
        public IEnumerable<Product> Apply(IEnumerable<Product> products)
        {
            IEnumerable<Product> filteredProducts = products;

            foreach (var filter in _filters)
            {
                filteredProducts = filter.Apply(filteredProducts);
            }

            return filteredProducts;
        }
    }
}