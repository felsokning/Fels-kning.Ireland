//-----------------------------------------------------------------------
// <copyright file="Passage.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Passage"/> class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Passage
    {
        /// <summary>
        ///     Gets or sets the passage duid
        /// </summary>
        [JsonPropertyName("duid")]
        public string Duid { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the passage last modification timestamp
        /// </summary>
        [JsonPropertyName("last_modification_timestamp")]
        public long LastModificationTimestamp { get; set; }

        /// <summary>
        ///     Gets or sets whether the passage is deleted
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        ///     Gets or sets the passage route duid
        /// </summary>
        [JsonPropertyName("route_duid")]
        public StructuredDuid RouteDuid { get; set; } = new StructuredDuid();

        /// <summary>
        ///     Gets or sets the passage direction.
        /// </summary>
        [JsonPropertyName("direction")]
        public int Direction { get; set; }

        /// <summary>
        ///     Gets or sets the passage trip duid
        /// </summary>
        [JsonPropertyName("trip_duid")]
        public StructuredDuid TripDuid { get; set; } = new StructuredDuid();

        /// <summary>
        ///     Gets or sets the passage stop point duid
        /// </summary>
        [JsonPropertyName("stop_point_duid")]
        public StructuredDuid StopPointDuid { get; set; } = new StructuredDuid();

        /// <summary>
        ///     Gets or sets the passage vehicle duid
        /// </summary>
        [JsonPropertyName("vehicle_duid")]
        public StructuredDuid VehicleDuid { get; set; } = new StructuredDuid();

        /// <summary>
        ///     Gets or sets the passage arrival data
        /// </summary>
        [JsonPropertyName("arrival_data")]
        public PassageData ArrivalData { get; set; } = new PassageData();

        /// <summary>
        ///     Gets or sets the passage departure data
        /// </summary>
        [JsonPropertyName("departure_data")]
        public PassageData DepartureData { get; set; } = new PassageData();

        /// <summary>
        ///     Gets or sets the passage congestion level
        /// </summary>
        [JsonPropertyName("congestion_level")]
        public int CongestionLevel { get; set; }

        /// <summary>
        ///     Gets or sets the passage accuracy level
        /// </summary>
        [JsonPropertyName("accuracy_level")]
        public int AccuracyLevel { get; set; }

        /// <summary>
        ///     Gets or sets the passage status
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        ///     Gets or sets whether the passage is accessible.
        /// </summary>
        [JsonPropertyName("is_accessible")]
        public int IsAccessible { get; set; }

        /// <summary>
        ///     Gets or sets the passage latitude
        /// </summary>
        [JsonPropertyName("latitude")]
        public int Latitude { get; set; }

        /// <summary>
        ///     Gets or sets the passage longitude
        /// </summary>
        [JsonPropertyName("longitude")]
        public int Longitude { get; set; }

        /// <summary>
        ///     Gets or sets the passage bearing
        /// </summary>
        [JsonPropertyName("bearing")]
        public int Bearing { get; set; }

        /// <summary>
        ///     Gets or sets the passage pattern duid
        /// </summary>
        [JsonPropertyName("pattern_duid")]
        public StructuredDuid PatternDuid { get; set; } = new StructuredDuid();

        /// <summary>
        ///     Gets or sets whether the passage has bike rack. 
        /// </summary>
        [JsonPropertyName("has_bike_rack")]
        public int HasBikeRack { get; set; }

        /// <summary>
        ///     Gets or sets the passage category.
        /// </summary>
        [JsonPropertyName("category")]
        public int Category { get; set; }
    }
}