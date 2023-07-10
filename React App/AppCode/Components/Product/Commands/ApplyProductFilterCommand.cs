using React_App.AppCode.Components.Product.Filters;
using React_App.AppCode.Interfaces;

namespace React_App.AppCode.Components.Product.Commands
{
    /// <summary>
    /// The FilterCommand class implements the ICommand interface and defines a binding between a Receiver object and an action.
    /// </summary>
    public class ApplyProductFilterCommand : ICommand
    {
        private readonly IProductFilter _filter;
        private IEnumerable<Models.Product>? _products;

        /// <summary>
        /// Initializes a new instance of the FilterCommand class.
        /// </summary>
        /// <param name="filter"> Filter to execute</param>
        /// <param name="products"> products list where the filter will be applied</param>
        public ApplyProductFilterCommand(IProductFilter filter, IEnumerable<Models.Product>? products)
        {
            _filter = filter;
            _products = products;
        }

        /// <summary>
        /// Executes the Apply command, invoking the corresponding operation in the Receiver.
        /// </summary>
        public void Execute()
        {
            _products = _filter.Apply(_products);
        }

        /// <summary>
        /// Method to get the final result after perform the command
        /// </summary>
        /// <returns> product list result after perform the command</returns>
        public IEnumerable<Models.Product>? GetExecutionResult()
        {
            return _products;
        }
    }
}