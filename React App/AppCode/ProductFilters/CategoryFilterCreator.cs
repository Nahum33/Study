using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    public class CategoryFilterCreator : IFilterCreator
    {
        private readonly CategoryFilter _categoryFilter;
        public CategoryFilterCreator(string categoryName)
        {
            _categoryFilter = new CategoryFilter(string.IsNullOrEmpty(categoryName) ? null : categoryName);
        }

        public IFilter Create()
        {
            return _categoryFilter;
        }
    }
}
