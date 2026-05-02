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
        /// <summary>
        /// Trip identifier.
        /// </summary>
        [JsonPropertyName("trip_id")]
        public string TripId { get; set; } = string.Empty;

        /// <summary>
        /// Route code for the trip.
        /// </summary>
        [JsonPropertyName("route_code")]
        public string RouteCode { get; set; } = string.Empty;

        /// <summary>
        /// Human-friendly route name.
        /// </summary>
        [JsonPropertyName("route_name")]
        public string RouteName { get; set; } = string.Empty;

        /// <summary>
        /// The trip headsign shown to passengers.
        /// </summary>
        [JsonPropertyName("trip_headsign")]
        public string TripHeadsign { get; set; } = string.Empty;

        /// <summary>
        /// Arrival time at the stop (as string/time).
        /// </summary>
        [JsonPropertyName("trip_stop_arrival_time")]
        public string TripStopArrivalTime { get; set; } = string.Empty;

        /// <summary>
        /// Departure time at the stop (as string/time).
        /// </summary>
        [JsonPropertyName("trip_stop_departure_time")]
        public string TripStopDepartureTime { get; set; } = string.Empty;

        /// <summary>
        /// Departure time as epoch seconds (raw integer).
        /// </summary>
        [JsonPropertyName("departure_time_raw")]
        public int DepartureTimeRaw { get; set; }

        /// <summary>
        /// Arrival time as epoch seconds (raw integer).
        /// </summary>
        [JsonPropertyName("arrival_time_raw")]
        public int ArrivalTimeRaw { get; set; }

        /// <summary>
        /// GTFS file identifier containing this trip.
        /// </summary>
        [JsonPropertyName("gtfs_file_id")]
        public int GtfsFileId { get; set; }

        /// <summary>
        /// Stop identifier for this trip entry.
        /// </summary>
        [JsonPropertyName("stop_id")]
        public string StopId { get; set; } = string.Empty;

        /// <summary>
        /// Short name for the trip.
        /// </summary>
        [JsonPropertyName("trip_short_name")]
        public string TripShortName { get; set; } = string.Empty;

        /// <summary>
        /// Sequence number of the stop within the trip.
        /// </summary>
        [JsonPropertyName("trip_stop_sequence")]
        public int TripStopSequence { get; set; }

        /// <summary>
        /// Direction identifier for the trip.
        /// </summary>
        [JsonPropertyName("trip_direction_id")]
        public int TripDirectionId { get; set; }

        /// <summary>
        /// Service identifier for the trip schedule.
        /// </summary>
        [JsonPropertyName("trip_service_id")]
        public int TripServiceId { get; set; }

        /// <summary>
        /// True if the trip runs on Monday.
        /// </summary>
        [JsonPropertyName("monday")]
        public bool Monday { get; set; }

        /// <summary>
        /// True if the trip runs on Tuesday.
        /// </summary>
        [JsonPropertyName("tuesday")]
        public bool Tuesday { get; set; }

        /// <summary>
        /// True if the trip runs on Wednesday.
        /// </summary>
        [JsonPropertyName("wednesday")]
        public bool Wednesday { get; set; }

        /// <summary>
        /// True if the trip runs on Thursday.
        /// </summary>
        [JsonPropertyName("thursday")]
        public bool Thursday { get; set; }

        /// <summary>
        /// True if the trip runs on Friday.
        /// </summary>
        [JsonPropertyName("friday")]
        public bool Friday { get; set; }

        /// <summary>
        /// True if the trip runs on Saturday.
        /// </summary>
        [JsonPropertyName("saturday")]
        public bool Saturday { get; set; }

        /// <summary>
        /// True if the trip runs on Sunday.
        /// </summary>
        [JsonPropertyName("sunday")]
        public bool Sunday { get; set; }

        /// <summary>
        /// Epoch seconds for the first stop time.
        /// </summary>
        [JsonPropertyName("first_stop_time_raw")]
        public int FirstStopTimeRaw { get; set; }

        /// <summary>
        /// Identifier for the last stop on the trip.
        /// </summary>
        [JsonPropertyName("last_stop_id")]
        public string LastStopId { get; set; } = string.Empty;

        /// <summary>
        /// Departure date string for the trip.
        /// </summary>
        [JsonPropertyName("departure_date")]
        public string DepartureDate { get; set; } = string.Empty;

        /// <summary>
        /// Trip date string.
        /// </summary>
        [JsonPropertyName("trip_date")]
        public string TripDate { get; set; } = string.Empty;

        /// <summary>
        /// Departure time ISO string.
        /// </summary>
        [JsonPropertyName("departure_at")]
        public string DepartureAt { get; set; } = string.Empty;

        /// <summary>
        /// Trip-specific departure time string.
        /// </summary>
        [JsonPropertyName("trip_departure_at")]
        public string TripDepartureAt { get; set; } = string.Empty;

        /// <summary>
        /// True if live data is available for this trip.
        /// </summary>
        [JsonPropertyName("has_live_data")]
        public bool HasLiveData { get; set; }

        /// <summary>
        /// Optional live data payload for the trip.
        /// </summary>
        [JsonPropertyName("live_data")]
        public LiveData LiveData { get; set; } = new LiveData();

        /// <summary>
        /// Vehicle identifier assigned to this trip.
        /// </summary>
        [JsonPropertyName("vehicle_id")]
        public string VehicleId { get; set; } = string.Empty;
    }
}