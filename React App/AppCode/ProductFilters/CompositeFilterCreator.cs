using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    public class CompositeFilterCreator : IFilterCreator
    {
        private readonly ProductFiltersModel _filterModel;
        public CompositeFilterCreator(ProductFiltersModel filterModel)
        {
            _filterModel = filterModel;
        }

        public IFilter Create()
        {
            // Here ais the rule of the filters
            var compositeFilter = new CompositeFilter();

            var categoryFilterCreator = new CategoryFilterCreator(_filterModel.ProductCategory);
            var nameFilterCreator = new NameFilterCreator(_filterModel.ProductName);
            var defaultFilterCreator = new DefaultFilterCreator();

            compositeFilter.AddFilter(categoryFilterCreator.Create());
            compositeFilter.AddFilter(nameFilterCreator.Create());
            compositeFilter.AddFilter(defaultFilterCreator.Create());

            return compositeFilter;
        }
    }
}
