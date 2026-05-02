//-----------------------------------------------------------------------
// <copyright file="TripStop.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TripStop"/> class.
    /// </summary>
    public class TripStop
    {
        /// <summary>
        /// Provider-specific identifier for the trip stop.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Stop identifier referenced by this trip stop.
        /// </summary>
        [JsonPropertyName("stop_id")]
        public string StopId { get; set; } = string.Empty;

        /// <summary>
        /// Numeric code for the trip stop.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// Display name for the trip stop.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Latitude coordinate of the trip stop.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude coordinate of the trip stop.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// GTFS file identifier containing this trip stop.
        /// </summary>
        [JsonPropertyName("gtfs_file_id")]
        public int GtfsFileId { get; set; }

        /// <summary>
        /// Geometry/geojson for the trip stop.
        /// </summary>
        [JsonPropertyName("geom")]
        public string Geom { get; set; } = string.Empty;
    }
}
