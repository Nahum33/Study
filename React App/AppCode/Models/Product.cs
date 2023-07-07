namespace React_App.AppCode.Models
{
    /// <summary>
    /// Model to map the properties for the product concept
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or Sets the identifier of the product
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the name of the product
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the price of the product
        /// </summary>
        public int Price { get; set; } = 0;

        /// <summary>
        /// Gets or Sets the thumbnail image of the product
        /// </summary>
        public string Thumbnail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the category of the product
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the isSelected flag in the UI
        /// </summary>
        public bool isSelected { get; set; } = false;
    }
}
