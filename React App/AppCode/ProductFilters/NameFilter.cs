using React_App.AppCode.Models;
using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    /// <summary>
    /// Name filter for products.
    /// </summary>
    public class NameFilter : IFilter
    {
        private readonly string? _name;

        public NameFilter(string? name = null)
        {
            _name = name;
        }

        /// <summary>
        /// Applies the name filter to the list of products.
        /// </summary>
        /// <param name="products">The list of products to filter.</param>
        /// <returns>The filtered list of products.</returns>
        public IEnumerable<Product> Apply(IEnumerable<Product> products)
        {
            return _name is null ? products : products.Where(p => p.Name.ToLower().Contains(_name.ToLower()));
        }
    }
}