//-----------------------------------------------------------------------
// <copyright file="Related.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Related"/> class.
    /// </summary>
    public class Related
    {
        /// <summary>
        ///     Gets or sets the related id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the related title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the related type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the related subject
        /// </summary>
        [JsonPropertyName("subject")]
        public List<Subject> Subject { get; set; } = new List<Subject>(0);

        /// <summary>
        ///     Gets or sets the related media
        /// </summary>
        [JsonPropertyName("media")]
        public List<Medium> Media { get; set; } = new List<Medium>(0);

        /// <summary>
        ///     Gets or sets the related number
        /// </summary>
        [JsonPropertyName("number")]
        public int? Number { get; set; }
    }
}