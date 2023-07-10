namespace React_App.AppCode.Components.Product.Filters
{
    /// <summary>
    /// The Filter interface declares a method to apply a Filter.
    /// </summary>
    public interface IProductFilter
    {
        /// <summary>
        /// Method to apply the filter
        /// </summary>
        IEnumerable<Models.Product>? Apply(IEnumerable<Models.Product>? products);
    }
}