//-----------------------------------------------------------------------
// <copyright file="BusStop.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="BusStop"/> class,
    ///     which is used to model the Bus Stops referenced by Bus Éireann.
    /// </summary>
    public class BusStop
    {
        /// <summary>
        ///     Gets or sets the DUID for the Bus Stop.
        /// </summary>
        [JsonPropertyName("duid")]
        public string Duid { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Last Modification Timestamp for the Bus Stop.
        /// </summary>
        [JsonPropertyName("last_modification_timestamp")]
        public long LastModificationTimestamp { get; set; } = int.MinValue;

        /// <summary>
        ///     Indicates whether the Bus Stop is Deleted.
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        ///     Gets or sets the Bus Stop type value.
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; } = int.MinValue;

        /// <summary>
        ///     Gets or sets the <see cref="StructuredDuid"/> for the Bus Stop.
        /// </summary>
        [JsonPropertyName("stop_duid")]
        public StructuredDuid StopDuid { get; set; } = new StructuredDuid();

        /// <summary>
        ///     Gets or sets the Bus Stop number.
        /// </summary>
        [JsonPropertyName("number")]
        public int Number { get; set; } = int.MinValue;

        /// <summary>
        ///     Gets or set the long name of the Bus Stop.
        /// </summary>
        [JsonPropertyName("long_name")]
        public string LongName { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or set the latitude of the Bus Stop.
        /// </summary>
        [JsonPropertyName("latitude")]
        public int Latitude { get; set; } = int.MinValue;

        /// <summary>
        ///     Gets or set the longitude of the Bus Stop.
        /// </summary>
        [JsonPropertyName("longitude")]
        public int Longitude { get; set; } = int.MinValue;

        /// <summary>
        ///     Gets or set the bearing of the Bus Stop.
        /// </summary>
        [JsonPropertyName("bearing")]
        public int Bearing { get; set; } = int.MinValue;

        /// <summary>
        ///     Gets or set the value indicating if the Bus Stop is accessible.
        /// </summary>
        [JsonPropertyName("is_accessible")]
        public int IsAccessible { get; set; } = int.MinValue;

        /// <summary>
        ///     Gets or set the code of the Bus Stop.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}