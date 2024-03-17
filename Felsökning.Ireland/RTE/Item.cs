//-----------------------------------------------------------------------
// <copyright file="Item.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Item"/> class.
    /// </summary>
    public class Item
    {
        /// <summary>
        ///     Gets or sets the item id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the item title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the item date time.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        ///     Gets or sets the item attributes.
        /// </summary>
        [JsonPropertyName("attribute")]
        public List<string> Attribute { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the item certification.
        /// </summary>
        [JsonPropertyName("certification")]
        public Certification Certification { get; set; } = new Certification();

        /// <summary>
        ///     Gets or sets the item summary.
        /// </summary>
        [JsonPropertyName("summary")]
        public Summary Summary { get; set; } = new Summary();

        /// <summary>
        ///     Gets or sets the item meta.
        /// </summary>
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } = new Meta();

        /// <summary>
        ///     Gets or sets the item asset.
        /// </summary>
        [JsonPropertyName("asset")]
        public Asset Asset { get; set; } = new Asset();

        /// <summary>
        ///     Gets or sets the item duration.
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }
    }
}