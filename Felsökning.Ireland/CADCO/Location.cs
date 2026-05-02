// ----------------------------------------------------------------------
// <copyright file="Location.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
using System.Text.Json.Serialization;

namespace Felsökning.Ireland.CADCO
{
    /// <summary>
    /// Represents a location object within the airport metadata.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The type of the location (for example "terminal" or "gate").
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// The name of the location.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The provider-specific identifier for the location.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
    }
}
