namespace React_App.AppCode.Components.Product.Filters
{
    /// <summary>
    /// Default filter for products.
    /// </summary>
    public class ProductDefaultFilter : IProductFilter
    {
        /// <summary>
        /// Initializes a new instance of the ProductDefaultFilter class.
        /// </summary>
        public ProductDefaultFilter() { }

        /// <summary>
        /// Applies the Default Filter to the list of products.
        /// </summary>
        /// <param name="products"> products list where the filter will be applied</param>
        public IEnumerable<Models.Product>? Apply(IEnumerable<Models.Product>? products)
        {
            Random random = new Random();
            return products is null ? Enumerable.Empty<Models.Product>()
                : products.OrderBy(x => random.Next()).Take(8);
        }
    }
}