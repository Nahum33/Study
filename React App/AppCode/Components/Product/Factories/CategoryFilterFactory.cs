using React_App.AppCode.Components.Product.Filters;

namespace React_App.AppCode.Components.Product.Factories
{
    /// <summary>
    /// Factory to create the Product Category Filter
    /// </summary>
    public class CategoryFilterFactory : IFilterFactory
    {
        private readonly string? _productCategory;

        /// <summary>
        /// Initializes a new instance of the CategoryFilterFactory class.
        /// </summary>
        /// <param name="productCategory"> product category text to apply as filter</param>
        public CategoryFilterFactory(string productCategory)
        {
            _productCategory = productCategory;
        }

        /// <summary>
        /// Method to execute the Create Operation from the Filter Factory
        /// </summary>
        /// <returns> a new ProductCategoryFilter object</returns>
        public IProductFilter Create()
        {
            return new ProductCategoryFilter(_productCategory);
        }
    }
}
