namespace React_App.AppCode.Models
{
    /// <summary>
    /// Model to map the properties for the service concept
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Gets or Sets the identifier of the service
        /// </summary>
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the name of the service
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the main image of the service
        /// </summary>
        public string MainImage { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the thumbnail image of the service
        /// </summary>
        public string Thumbnail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the category of the service
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the category of the service
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
