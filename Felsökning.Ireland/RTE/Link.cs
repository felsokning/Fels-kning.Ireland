//-----------------------------------------------------------------------
// <copyright file="Link.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Link"/> class.
    /// </summary>
    public class Link
    {
        /// <summary>
        ///     Gets or sets the rel
        /// </summary>
        [JsonPropertyName("rel")]
        public string Rel { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the hyperlink reference.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; } = string.Empty;
    }
}