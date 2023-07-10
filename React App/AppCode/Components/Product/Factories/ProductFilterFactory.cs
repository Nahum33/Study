using React_App.AppCode.Components.Product.Filters;

namespace React_App.AppCode.Components.Product.Factories
{
    public class ProductFilterFactory : IFilterFactory
    {
        private readonly Models.ProductFiltersModel _filterModel;

        /// <summary>
        /// Initializes a new instance of the ProductNameFilter class.
        /// </summary>
        /// <param name="filterModel"> product filters property to apply as filter</param>
        public ProductFilterFactory(Models.ProductFiltersModel filterModel)
        {
            _filterModel = filterModel;
        }

        /// <summary>
        /// Method to execute the Create Operation from the Filter Factory
        /// </summary>
        /// <returns> a new CompositeFilter object</returns>
        public IProductFilter Create()
        {
            var productFilter = new CompositeProductFilter();

            var categoryFilterCreator = new CategoryFilterFactory(_filterModel.ProductCategory);
            var nameFilterCreator = new NameFilterFactory(_filterModel.ProductName);
            var defaultFilterCreator = new DefaultFilterFactory();

            productFilter.AddFilter(categoryFilterCreator.Create());
            productFilter.AddFilter(nameFilterCreator.Create());
            productFilter.AddFilter(defaultFilterCreator.Create());

            return productFilter;
        }
    }
}
