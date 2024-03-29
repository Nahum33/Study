﻿namespace React_App.AppCode.Components.Product.Models
{
    /// <summary>
    /// Model to map the properties for the product concept
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or Sets the identifier of the product
        /// </summary>
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the name of the product
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the price of the product
        /// </summary>
        public decimal Price { get; set; } = 0;

        /// <summary>
        /// Gets or Sets the thumbnail image of the product
        /// </summary>
        public string Thumbnail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the category of the product
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the category of the product
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
