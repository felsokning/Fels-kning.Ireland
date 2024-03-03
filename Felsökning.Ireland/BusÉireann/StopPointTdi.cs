namespace Felsökning.Ireland.BusÉireann
{
    public class StopPointTdi
    {
        [JsonPropertyName("bus_stop_0")]
        public BusStop BusStop0 { get; set; }

        [JsonPropertyName("bus_stop_1")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BusStop BusStop1 { get; set; }

        [JsonPropertyName("bus_stop_2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BusStop BusStop2 { get; set; }

        [JsonPropertyName("bus_stop_3")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BusStop BusStop3 { get; set; }

        [JsonPropertyName("bus_stop_4")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BusStop BusStop4 { get; set; }

        [JsonPropertyName("bus_stop_5")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BusStop BusStop5 { get; set; }

        [JsonPropertyName("bus_stop_6")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BusStop BusStop6 { get; set; }

        [JsonPropertyName("bus_stop_7")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BusStop BusStop7 { get; set; }
    }
}