//-----------------------------------------------------------------------
// <copyright file="Default.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Default"/> class.
    /// </summary>
    public class Default
    {
        /// <summary>
        ///     Gets or set the default hyperlink reference.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or set the default width.
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        ///     Gets or set the default height.
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}