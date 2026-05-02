//-----------------------------------------------------------------------
// <copyright file="BasicStatus.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="BasicStatus"/> class.
    /// </summary>
    public class BasicStatus
    {
        /// <summary>
        /// The arrival delay in seconds, if available.
        /// </summary>
        [JsonPropertyName("arrival_delay_in_seconds")]
        public int ArrivalDelayInSeconds { get; set; }

        /// <summary>
        /// The departure delay in seconds, if available.
        /// </summary>
        [JsonPropertyName("departure_delay_in_seconds")]
        public int DepartureDelayInSeconds { get; set; }

        /// <summary>
        /// Human readable status text (e.g., "on time").
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Expected arrival time as returned by the API.
        /// </summary>
        [JsonPropertyName("expected_arrival_time")]
        public string ExpectedArrivalTime { get; set; } = string.Empty;

        /// <summary>
        /// Expected departure time as returned by the API.
        /// </summary>
        [JsonPropertyName("expected_departure_time")]
        public string ExpectedDepartureTime { get; set; } = string.Empty;

        /// <summary>
        /// Expected arrival as a parsed <see cref="DateTime"/> value.
        /// </summary>
        [JsonPropertyName("expected_arrival_date_time")]
        public DateTime ExpectedArrivalDateTime { get; set; }

        /// <summary>
        /// Expected departure as a parsed <see cref="DateTime"/> value.
        /// </summary>
        [JsonPropertyName("expected_departure_date_time")]
        public DateTime ExpectedDepartureDateTime { get; set; }
    }
}