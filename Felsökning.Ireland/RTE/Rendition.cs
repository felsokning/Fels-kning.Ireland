//-----------------------------------------------------------------------
// <copyright file="Rendition.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Rendition"/> class.
    /// </summary>
    public class Rendition
    {
        /// <summary>
        ///     Gets or sets the rendition default.
        /// </summary>
        [JsonPropertyName("default")]
        public Default Default { get; set; } = new Default();
    }
}