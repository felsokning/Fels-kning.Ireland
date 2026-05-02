// ----------------------------------------------------------------------
// <copyright file="CodeShare.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
using System.Text.Json.Serialization;

namespace Felsökning.Ireland.CADCO
{
    /// <summary>
    /// Represents a codeshare entry for a flight.
    /// </summary>
    public class CodeShare
    {
        /// <summary>
        /// The identifier of the airline providing the codeshare.
        /// </summary>
        [JsonPropertyName("airlineId")]
        public string AirlineId { get; set; } = string.Empty;

        /// <summary>
        /// The display name of the airline providing the codeshare.
        /// </summary>
        [JsonPropertyName("airlineName")]
        public string AirlineName { get; set; } = string.Empty;

        /// <summary>
        /// The flight number for the codeshare entry.
        /// </summary>
        [JsonPropertyName("flightNumber")]
        public string FlightNumber { get; set; } = string.Empty;
    }
}
