namespace Felsökning.Ireland.BusÉireann
{
    public class PassageData
    {
        [JsonPropertyName("scheduled_passage_time_utc")]
        public int ScheduledPassageTimeUtc { get; set; }

        [JsonPropertyName("scheduled_passage_time")]
        public string ScheduledPassageTime { get; set; }

        [JsonPropertyName("actual_passage_time_utc")]
        public int ActualPassageTimeUtc { get; set; }

        [JsonPropertyName("actual_passage_time")]
        public string ActualPassageTime { get; set; }

        [JsonPropertyName("service_mode")]
        public int ServiceMode { get; set; }

        [JsonPropertyName("multilingual_direction_text")]
        public MultilingualDirectionText MultilingualDirectionText { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }
    }
}