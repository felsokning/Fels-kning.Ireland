//-----------------------------------------------------------------------
// <copyright file="Medium.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Medium"/> class.
    /// </summary>
    public class Medium
    {
        /// <summary>
        ///     Gets or sets the medium kind
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the medium rendition
        /// </summary>
        [JsonPropertyName("rendition")]
        public Rendition Rendition { get; set; } = new Rendition();

        /// <summary>
        ///     Gets or sets the medium copyright
        /// </summary>
        [JsonPropertyName("copyright")]
        public string Copyright { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the medium expiry
        /// </summary>
        [JsonPropertyName("expiry")]
        public DateTime Expiry { get; set; }
    }
}