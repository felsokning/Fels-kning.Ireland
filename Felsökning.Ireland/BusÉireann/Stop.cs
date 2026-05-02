//-----------------------------------------------------------------------
// <copyright file="StructuredDuid.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Stop"/> class.
    /// </summary>
    public class Stop
    {
        /// <summary>
        /// Provider-specific identifier for the stop.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The stop identifier used by the provider.
        /// </summary>
        [JsonPropertyName("stop_id")]
        public string StopId { get; set; } = string.Empty;

        /// <summary>
        /// Short stop code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Display name of the stop.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Latitude coordinate of the stop.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude coordinate of the stop.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Identifier of the GTFS file that contains this stop.
        /// </summary>
        [JsonPropertyName("gtfs_file_id")]
        public int GtfsFileId { get; set; }

        /// <summary>
        /// Geometry/geojson payload for the stop location.
        /// </summary>
        [JsonPropertyName("geom")]
        public string Geom { get; set; } = string.Empty;

        /// <summary>
        /// Full compound code for the stop.
        /// </summary>
        [JsonPropertyName("fullCode")]
        public string FullCode { get; set; } = string.Empty;

        /// <summary>
        /// FF code value for the stop.
        /// </summary>
        [JsonPropertyName("ffCode")]
        public string FfCode { get; set; } = string.Empty;

        /// <summary>
        /// NTA name of the stop area.
        /// </summary>
        [JsonPropertyName("ntaName")]
        public string NtaName { get; set; } = string.Empty;

        /// <summary>
        /// City in which the stop is located.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Optional weight used for sorting or prioritization.
        /// </summary>
        [JsonPropertyName("weight")]
        public int? Weight { get; set; }
    }
}