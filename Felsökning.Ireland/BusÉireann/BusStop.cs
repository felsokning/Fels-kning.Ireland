using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felsökning.Ireland.BusÉireann
{
    public class BusStop
    {
        [JsonPropertyName("duid")]
        public string Duid { get; set; }

        [JsonPropertyName("last_modification_timestamp")]
        public long LastModificationTimestamp { get; set; }

        [JsonPropertyName("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("stop_duid")]
        public StructuredDuid StopDuid { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("long_name")]
        public string LongName { get; set; }

        [JsonPropertyName("latitude")]
        public int Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public int Longitude { get; set; }

        [JsonPropertyName("bearing")]
        public int Bearing { get; set; }

        [JsonPropertyName("is_accessible")]
        public int IsAccessible { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}