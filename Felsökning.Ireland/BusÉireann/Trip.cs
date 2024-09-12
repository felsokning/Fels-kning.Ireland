//-----------------------------------------------------------------------
// <copyright file="Trip.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Trip"/> class.
    /// </summary>
    public class Trip
    {
        [JsonPropertyName("trip_id")]
        public string TripId { get; set; }

        [JsonPropertyName("route_code")]
        public string RouteCode { get; set; }

        [JsonPropertyName("route_name")]
        public string RouteName { get; set; }

        [JsonPropertyName("trip_headsign")]
        public string TripHeadsign { get; set; }

        [JsonPropertyName("trip_stop_arrival_time")]
        public string TripStopArrivalTime { get; set; }

        [JsonPropertyName("trip_stop_departure_time")]
        public string TripStopDepartureTime { get; set; }

        [JsonPropertyName("departure_time_raw")]
        public int DepartureTimeRaw { get; set; }

        [JsonPropertyName("arrival_time_raw")]
        public int ArrivalTimeRaw { get; set; }

        [JsonPropertyName("gtfs_file_id")]
        public int GtfsFileId { get; set; }

        [JsonPropertyName("stop_id")]
        public string StopId { get; set; }

        [JsonPropertyName("trip_short_name")]
        public string TripShortName { get; set; }

        [JsonPropertyName("trip_stop_sequence")]
        public int TripStopSequence { get; set; }

        [JsonPropertyName("trip_direction_id")]
        public int TripDirectionId { get; set; }

        [JsonPropertyName("trip_service_id")]
        public int TripServiceId { get; set; }

        [JsonPropertyName("monday")]
        public bool Monday { get; set; }

        [JsonPropertyName("tuesday")]
        public bool Tuesday { get; set; }

        [JsonPropertyName("wednesday")]
        public bool Wednesday { get; set; }

        [JsonPropertyName("thursday")]
        public bool Thursday { get; set; }

        [JsonPropertyName("friday")]
        public bool Friday { get; set; }

        [JsonPropertyName("saturday")]
        public bool Saturday { get; set; }

        [JsonPropertyName("sunday")]
        public bool Sunday { get; set; }

        [JsonPropertyName("first_stop_time_raw")]
        public int FirstStopTimeRaw { get; set; }

        [JsonPropertyName("last_stop_id")]
        public string LastStopId { get; set; }

        [JsonPropertyName("departure_date")]
        public string DepartureDate { get; set; }

        [JsonPropertyName("trip_date")]
        public string TripDate { get; set; }

        [JsonPropertyName("departure_at")]
        public string DepartureAt { get; set; }

        [JsonPropertyName("trip_departure_at")]
        public string TripDepartureAt { get; set; }

        [JsonPropertyName("has_live_data")]
        public bool HasLiveData { get; set; }

        [JsonPropertyName("live_data")]
        public LiveData LiveData { get; set; }

        [JsonPropertyName("vehicle_id")]
        public string VehicleId { get; set; }
    }
}