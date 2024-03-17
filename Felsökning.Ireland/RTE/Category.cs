//-----------------------------------------------------------------------
// <copyright file="Category.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Category"/> class.
    /// </summary>
    public class Category
    {
        /// <summary>
        ///     Gets or sets the category code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the category name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the category dvb.
        /// </summary>
        [JsonPropertyName("dvb")]
        public string Dvb { get; set; } = string.Empty;
    }
}