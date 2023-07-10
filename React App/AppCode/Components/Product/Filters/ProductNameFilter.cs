namespace React_App.AppCode.Components.Product.Filters
{
    /// <summary>
    /// Name filter for products.
    /// </summary>
    public class ProductNameFilter : IProductFilter
    {
        private readonly string _productName;

        /// <summary>
        /// Initializes a new instance of the ProductNameFilter class.
        /// </summary>
        /// <param name="productName"> product name text to apply as filter</param>
        public ProductNameFilter(string? productName)
        {
            _productName = productName ?? string.Empty;
        }

        /// <summary>
        /// Applies the Name Filter to the list of products.
        /// </summary>
        /// <param name="products"> products list where the filter will be applied</param>
        public IEnumerable<Models.Product>? Apply(IEnumerable<Models.Product>? products)
        {
            if (string.IsNullOrEmpty(_productName))
            {
                return products;
            }

            return products is null ? Enumerable.Empty<Models.Product>()
                : products.Where(p => p.Name.ToLower().Contains(_productName.ToLower()));
        }
    }
}