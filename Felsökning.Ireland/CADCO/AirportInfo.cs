// ----------------------------------------------------------------------
// <copyright file="AirportInfo.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Felsökning.Ireland.CADCO
{
    /// <summary>
    /// Represents airport metadata returned by the SkyScanner API.
    /// </summary>
    public class AirportInfo
    {
        /// <summary>
        /// Indicates whether the airport has commercial operations.
        /// </summary>
        [JsonPropertyName("commercial")]
        public bool Commercial { get; set; }

        /// <summary>
        /// The IATA code for the airport (e.g. "DUB").
        /// </summary>
        [JsonPropertyName("iataCode")]
        public string IataCode { get; set; } = string.Empty;

        /// <summary>
        /// The human-readable name of the airport.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The provider-specific identifier for the airport.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// One or more location entries associated with the airport.
        /// </summary>
        [JsonPropertyName("location")]
        public List<Location> Location { get; set; } = new List<Location>();
    }
}
