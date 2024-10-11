namespace React_App.AppCode.Commands.Models
{
    /// <summary>
    /// Model for map search command parameters from the client side
    /// </summary>
    public class SearchCommand
    {
        /// <summary>
        /// Gets or sets the search term value.
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// Gets or sets the category value.
        /// </summary>
        public string? Category { get; set; }
    }
}