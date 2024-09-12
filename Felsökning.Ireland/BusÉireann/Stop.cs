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
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("stop_id")]
        public string StopId { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

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

        [JsonPropertyName("fullCode")]
        public string FullCode { get; set; }

        [JsonPropertyName("ffCode")]
        public string FfCode { get; set; }

        [JsonPropertyName("ntaName")]
        public string NtaName { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("weight")]
        public int? Weight { get; set; }
    }
}