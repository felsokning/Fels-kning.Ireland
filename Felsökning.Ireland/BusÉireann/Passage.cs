namespace Felsökning.Ireland.BusÉireann
{
    public class Passage
    {
        [JsonPropertyName("duid")]
        public string Duid { get; set; }

        [JsonPropertyName("last_modification_timestamp")]
        public long LastModificationTimestamp { get; set; }

        [JsonPropertyName("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("route_duid")]
        public StructuredDuid RouteDuid { get; set; }

        [JsonPropertyName("direction")]
        public int Direction { get; set; }

        [JsonPropertyName("trip_duid")]
        public StructuredDuid TripDuid { get; set; }

        [JsonPropertyName("stop_point_duid")]
        public StructuredDuid StopPointDuid { get; set; }

        [JsonPropertyName("vehicle_duid")]
        public StructuredDuid VehicleDuid { get; set; }

        [JsonPropertyName("arrival_data")]
        public PassageData ArrivalData { get; set; }

        [JsonPropertyName("departure_data")]
        public PassageData DepartureData { get; set; }

        [JsonPropertyName("congestion_level")]
        public int CongestionLevel { get; set; }

        [JsonPropertyName("accuracy_level")]
        public int AccuracyLevel { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("is_accessible")]
        public int IsAccessible { get; set; }

        [JsonPropertyName("latitude")]
        public int Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public int Longitude { get; set; }

        [JsonPropertyName("bearing")]
        public int Bearing { get; set; }

        [JsonPropertyName("pattern_duid")]
        public StructuredDuid PatternDuid { get; set; }

        [JsonPropertyName("has_bike_rack")]
        public int HasBikeRack { get; set; }

        [JsonPropertyName("category")]
        public int Category { get; set; }
    }
}