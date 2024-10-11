namespace React_App.AppCode.Models
{
    /// <summary>
    /// Model to map the properties for the trade concept
    /// </summary>
    public class Trade
    {
        /// <summary>
        /// Gets or Sets the identifier of the trade
        /// </summary>
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the name of the trade
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the main image of the trade
        /// </summary>
        public string MainImage { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the thumbnail image of the trade
        /// </summary>
        public string Thumbnail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the category of the trade
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the category of the trade
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
