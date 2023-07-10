using React_App.AppCode.Components.Product.Filters;

namespace React_App.AppCode.Components.Product.Factories
{
    /// <summary>
    /// Factory to create the Product Default Filter
    /// </summary>
    public class DefaultFilterFactory : IFilterFactory
    {
        /// <summary>
        /// Initializes a new instance of the CategoryFilterFactory class.
        /// </summary>
        public DefaultFilterFactory() { }

        /// <summary>
        /// Method to execute the Create Operation from the Filter Factory
        /// </summary>
        /// <returns> a new ProductDefaultFilter object</returns>
        public IProductFilter Create()
        {
            return new ProductDefaultFilter();
        }
    }
}
