namespace Felsökning.Ireland.BusÉireann
{
    public class StructuredDuid
    {
        [JsonPropertyName("structTag")]
        public int StructTag { get; set; }

        [JsonPropertyName("duid")]
        public string Duid { get; set; }
    }
}