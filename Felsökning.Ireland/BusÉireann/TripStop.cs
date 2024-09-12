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
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("stop_id")]
        public string StopId { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("gtfs_file_id")]
        public int GtfsFileId { get; set; }

        [JsonPropertyName("geom")]
        public string Geom { get; set; }
    }
}
