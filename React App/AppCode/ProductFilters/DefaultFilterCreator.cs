using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    public class DefaultFilterCreator
    {
        private readonly DefaultFilter _defaultFilter;
        public DefaultFilterCreator()
        {
            _defaultFilter = new DefaultFilter();
        }

        public IFilter Create()
        {
            return _defaultFilter;
        }
    }
}
