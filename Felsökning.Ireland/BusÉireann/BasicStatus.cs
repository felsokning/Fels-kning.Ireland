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
        [JsonPropertyName("arrival_delay_in_seconds")]
        public int ArrivalDelayInSeconds { get; set; }

        [JsonPropertyName("departure_delay_in_seconds")]
        public int DepartureDelayInSeconds { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("expected_arrival_time")]
        public string ExpectedArrivalTime { get; set; }

        [JsonPropertyName("expected_departure_time")]
        public string ExpectedDepartureTime { get; set; }

        [JsonPropertyName("expected_arrival_date_time")]
        public DateTime ExpectedArrivalDateTime { get; set; }

        [JsonPropertyName("expected_departure_date_time")]
        public DateTime ExpectedDepartureDateTime { get; set; }
    }
}