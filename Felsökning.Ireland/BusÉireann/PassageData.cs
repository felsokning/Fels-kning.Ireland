//-----------------------------------------------------------------------
// <copyright file="PassageData.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PassageData"/> class.
    /// </summary>
    public class PassageData
    {
        /// <summary>
        ///     Gets or sets the scheduled passage time UTC of the passage data.
        /// </summary>
        [JsonPropertyName("scheduled_passage_time_utc")]
        public int ScheduledPassageTimeUtc { get; set; }

        /// <summary>
        ///     Gets or sets the scheduled passage time of the passage data.
        /// </summary>
        [JsonPropertyName("scheduled_passage_time")]
        public string ScheduledPassageTime { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the actual passage time UTC of the passage data.
        /// </summary>
        [JsonPropertyName("actual_passage_time_utc")]
        public int ActualPassageTimeUtc { get; set; }

        /// <summary>
        ///     Gets or sets the actual passage time of the passage data.
        /// </summary>
        [JsonPropertyName("actual_passage_time")]
        public string ActualPassageTime { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the service mode of the passage data.
        /// </summary>
        [JsonPropertyName("service_mode")]
        public int ServiceMode { get; set; }

        /// <summary>
        ///     Gets or sets the multilingual direction text of the passage data.
        /// </summary>
        [JsonPropertyName("multilingual_direction_text")]
        public MultilingualDirectionText MultilingualDirectionText { get; set; } = new MultilingualDirectionText();

        /// <summary>
        ///     Gets or sets the type of the passage data.
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }
    }
}