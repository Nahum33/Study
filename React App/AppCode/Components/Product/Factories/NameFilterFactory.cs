using React_App.AppCode.Components.Product.Filters;

namespace React_App.AppCode.Components.Product.Factories
{
    /// <summary>
    /// Factory to create the Product Default Filter
    /// </summary>
    public class NameFilterFactory : IFilterFactory
    {
        private readonly string? _productName;

        /// <summary>
        /// Initializes a new instance of the CategoryFilterFactory class.
        /// </summary>
        /// <param name="productName"> product name text to apply as filter</param>
        public NameFilterFactory(string productName)
        {
            _productName = productName;
        }

        /// <summary>
        /// Method to execute the Create Operation from the Filter Factory
        /// </summary>
        /// <returns> a new ProductNameFilter object</returns>
        public IProductFilter Create()
        {
            return new ProductNameFilter(_productName);
        }
    }
}
