using React_App.AppCode.Models;
using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    /// <summary>
    /// The FilterCommand class implements the ICommand interface and defines a binding between a Receiver object and an action.
    /// </summary>
    public class FilterCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the FilterCommand class.
        /// </summary>
        public FilterCommand() { }

        /// <summary>
        /// Executes the Apply command, invoking the corresponding operation in the Receiver.
        /// </summary>
        /// <param name="products"> Products List to filtered</param>
        /// <param name="filters"> Filters model to apply</param>
        /// <returns>Product list filtered</returns>
        public IEnumerable<Product> Apply(IEnumerable<Product> products, ProductFiltersModel filters)
        {
            var compositeFilter = new CompositeFilter();
            if (filters.HasFilters)
            {
                if (!string.IsNullOrEmpty(filters.ProductCategory))
                {
                    compositeFilter.AddFilter(new CategoryFilter(filters.ProductCategory));
                }

                if (!string.IsNullOrEmpty(filters.ProductName))
                {
                    compositeFilter.AddFilter(new NameFilter(filters.ProductName));
                }
            }
            else
            {
                compositeFilter.AddFilter(new DefaultFilter());
            }

            return compositeFilter.Apply(products);
        }
    }
}