using React_App.AppCode.Models;
using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    /// <summary>
    /// Category filter for products.
    /// </summary>
    public class CategoryFilter : IComposite
    {
        private readonly string _category;

        public CategoryFilter(string category)
        {
            _category = category;
        }

        /// <summary>
        /// Applies the category filter to the list of products.
        /// </summary>
        /// <param name="products">The list of products to filter.</param>
        /// <returns>The filtered list of products.</returns>
        public IEnumerable<Product> Apply(IEnumerable<Product> products)
        {
            return products.Where(p => p.Category.ToLower() == _category.ToLower());
        }
    }
}