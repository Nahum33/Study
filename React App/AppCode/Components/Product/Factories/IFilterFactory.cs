using React_App.AppCode.Components.Product.Filters;

namespace React_App.AppCode.Components.Product.Factories
{
    /// <summary>
    /// The FilterFactory interface declares a method to create a Filter.
    /// </summary>
    public interface IFilterFactory
    {
        /// <summary>
        /// Method to execute the Create Operation from the Filter Factory
        /// </summary>
        /// <returns> a new IProductFilter object</returns>
        IProductFilter Create();
    }
}
