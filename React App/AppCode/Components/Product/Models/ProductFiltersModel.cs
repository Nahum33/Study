namespace React_App.AppCode.Components.Product.Models
{
    /// <summary>
    /// Model for filtering products.
    /// </summary>
    public class ProductFiltersModel
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        public string ProductCategory { get; set; } = string.Empty;
    }
}