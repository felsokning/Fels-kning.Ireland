//-----------------------------------------------------------------------
// <copyright file="ShortListing.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ShortListing"/> class,
    ///     which contains the short listings.
    /// </summary>
    public class ShortListing
    {
        /// <summary>
        ///     Gets or sets a value indicating if there is more data.
        /// </summary>
        [JsonPropertyName("hasNext")]
        public bool HasNext { get; set; }

        /// <summary>
        ///     Gets or sets the total number of listings.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        ///     Gets or sets the list of <see cref="Item"/>
        /// </summary>
        [JsonPropertyName("item")]
        public List<Item> Item { get; set; } = new List<Item>(0);
    }
}