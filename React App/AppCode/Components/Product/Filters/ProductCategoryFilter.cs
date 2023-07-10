namespace React_App.AppCode.Components.Product.Filters
{
    /// <summary>
    /// Category filter for products.
    /// </summary>
    public class ProductCategoryFilter : IProductFilter
    {
        private readonly string? _productCategory;

        /// <summary>
        /// Initializes a new instance of the ProductCategoryFilter class.
        /// </summary>
        /// <param name="productCategory"> product category text to apply as filter</param>
        public ProductCategoryFilter(string? productCategory)
        {
            _productCategory = productCategory;
        }

        /// <summary>
        /// Applies the Category Filter to the list of products.
        /// </summary>
        /// <param name="products"> products list where the filter will be applied</param>
        public IEnumerable<Models.Product>? Apply(IEnumerable<Models.Product>? products)
        {
            if (string.IsNullOrEmpty(_productCategory))
            {
                return products;
            }

            return products is null ? Enumerable.Empty<Models.Product>()
                : products.Where(p => p.Category.ToLower().Equals(_productCategory.ToLower()));
        }
    }
}