using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    public class NameFilterCreator
    {
        private readonly NameFilter _nameFilter;
        public NameFilterCreator(string nameFilter)
        {
            _nameFilter = new NameFilter(string.IsNullOrEmpty(nameFilter) ? null : nameFilter);
        }

        public IFilter Create()
        {
            return _nameFilter;
        }
    }
}
