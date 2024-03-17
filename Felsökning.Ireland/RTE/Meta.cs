//-----------------------------------------------------------------------
// <copyright file="Meta.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Meta"/> class.
    /// </summary>
    public class Meta
    {
        /// <summary>
        ///     Gets or sets the meta running-time
        /// </summary>
        [JsonPropertyName("running-time")]
        public string RunningTime { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta best-known-for
        /// </summary>
        [JsonPropertyName("best-known-for")]
        public string BestKnownFor { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta early-life
        /// </summary>
        [JsonPropertyName("early-life")]
        public string EarlyLife { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta career
        /// </summary>
        [JsonPropertyName("career")]
        public string Career { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta quote
        /// </summary>
        [JsonPropertyName("quote")]
        public string Quote { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta trivia
        /// </summary>
        [JsonPropertyName("trivia")]
        public string Trivia { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta star-rating
        /// </summary>
        [JsonPropertyName("starRating")]
        public string StarRating { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta episode
        /// </summary>
        [JsonPropertyName("episode")]
        public string Episode { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the meta episode total
        /// </summary>
        [JsonPropertyName("episodeTotal")]
        public string EpisodeTotal { get; set; } = string.Empty;
    }
}