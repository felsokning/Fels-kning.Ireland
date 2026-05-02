// ----------------------------------------------------------------------
// <copyright file="SkyScannerResponse.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Felsökning.Ireland.CADCO
{
    /// <summary>
    /// Represents the response wrapper returned by the SkyScanner arrivals/departures API.
    /// </summary>
    internal class SkyScannerResponse
    {
        [JsonPropertyName("airportInfo")]
        public AirportInfo AirportInfo { get; set; } = new AirportInfo();

        [JsonPropertyName("arrivals")]
        public List<FlightInformation> Arrivals { get; set; } = new List<FlightInformation>();

        [JsonPropertyName("departures")]
        public List<FlightInformation> Departures { get; set; } = new List<FlightInformation>();
    }
}
