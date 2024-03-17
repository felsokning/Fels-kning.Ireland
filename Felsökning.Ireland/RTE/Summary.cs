//-----------------------------------------------------------------------
// <copyright file="Summary.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Summary"/> class.
    /// </summary>
    public class Summary
    {
        /// <summary>
        ///     Gets or sets the short summary.
        /// </summary>
        [JsonPropertyName("short")]
        public string Short { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the medium summary.
        /// </summary>
        [JsonPropertyName("medium")]
        public string Medium { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the long summary.
        /// </summary>
        [JsonPropertyName("long")]
        public string Long { get; set; } = string.Empty;
    }
}