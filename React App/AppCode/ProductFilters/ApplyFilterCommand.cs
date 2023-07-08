using React_App.AppCode.Models;
using React_App.AppCode.Interfaces;

namespace React_App.AppCode.ProductFilters
{
    /// <summary>
    /// The FilterCommand class implements the ICommand interface and defines a binding between a Receiver object and an action.
    /// </summary>
    public class ApplyFilterCommand : ICommand
    {
        private readonly IFilter _filter;

        /// <summary>
        /// Initializes a new instance of the FilterCommand class.
        /// </summary>
        /// <param name="filter"> Filters model to apply</param>
        public ApplyFilterCommand(IFilter filter)
        {
            _filter = filter;
        }

        /// <summary>
        /// Executes the Apply command, invoking the corresponding operation in the Receiver.
        /// </summary>
        /// <param name="products"> Products List to filtered</param>
        /// <returns>Product list filtered</returns>
        public IEnumerable<Product> Execute(IEnumerable<Product> products)
        {
            return _filter.Apply(products);
        }
    }
}