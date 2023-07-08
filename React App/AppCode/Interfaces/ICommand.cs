using React_App.AppCode.Models;
using React_App.AppCode.ProductFilters;

namespace React_App.AppCode.Interfaces
{
    /// <summary>
    /// The Command interface declares a method for executing a command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="products"> Products List to filtered</param>
        /// <returns>The filtered list of products.</returns>
        IEnumerable<Product> Execute(IEnumerable<Product> products);
    }
}