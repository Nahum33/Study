namespace React_App.AppCode.Components.Product.Filters
{
    /// <summary>
    /// Name filter for products.
    /// </summary>
    public class CompositeProductFilter : IProductFilter
    {
        private readonly List<IProductFilter> _filters;

        /// <summary>
        /// Initializes a new instance of the ProductFilter class.
        /// </summary>
        public CompositeProductFilter()
        {
            _filters = new List<IProductFilter>();
        }

        /// <summary>
        /// Method to apply the filters in the order that were added
        /// </summary>
        public IEnumerable<Models.Product>? Apply(IEnumerable<Models.Product>? products)
        {
            if (products is null)
            {
                return Enumerable.Empty<Models.Product>();
            }

            foreach (var filter in _filters)
            {
                products = filter.Apply(products);
            }

            return products;
        }

        /// <summary>
        /// Adds a filter to the composite filter. The filters should be added in order it does wants to applied
        /// </summary>
        /// <param name="filter">The filter to add.</param>
        public void AddFilter(IProductFilter filter)
        {
            _filters.Add(filter);
        }
    }
}