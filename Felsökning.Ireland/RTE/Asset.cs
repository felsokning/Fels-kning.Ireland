//-----------------------------------------------------------------------
// <copyright file="Asset.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Asset"/> class.
    /// </summary>
    public class Asset
    {
        /// <summary>
        ///     Gets or sets the asset id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the asset type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the asset title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the asset attributes.
        /// </summary>
        [JsonPropertyName("attribute")]
        public List<string> Attribute { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the asset categories.
        /// </summary>
        [JsonPropertyName("category")]
        public List<Category> Category { get; set; } = new List<Category>(0);

        /// <summary>
        ///     Gets or sets the asset contributors.
        /// </summary>
        [JsonPropertyName("contributor")]
        public List<Contributor> Contributor { get; set; } = new List<Contributor>(0);

        /// <summary>
        ///     Gets or sets the asset certification.
        /// </summary>
        [JsonPropertyName("certification")]
        public Certification Certification { get; set; } = new Certification();

        /// <summary>
        ///     Gets or sets the asset metadata.
        /// </summary>
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } = new Meta();

        /// <summary>
        ///     Gets or sets the asset summary.
        /// </summary>
        [JsonPropertyName("summary")]
        public Summary Summary { get; set; } = new Summary();

        /// <summary>
        ///     Gets or sets the asset mediums.
        /// </summary>
        [JsonPropertyName("media")]
        public List<Medium> Media { get; set; } = new List<Medium>(0);

        /// <summary>
        ///     Gets or sets the asset relateds.
        /// </summary>
        [JsonPropertyName("related")]
        public List<Related> Related { get; set; } = new List<Related>(0);

        /// <summary>
        ///     Gets or sets the asset subjects.
        /// </summary>
        [JsonPropertyName("subject")]
        public List<Subject> Subject { get; set; } = new List<Subject>(0);

        /// <summary>
        ///     Gets or sets the asset links.
        /// </summary>
        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);

        /// <summary>
        ///     Gets or sets the asset deep links.
        /// </summary>
        [JsonPropertyName("deeplink")]
        public List<object> Deeplink { get; set; } = new List<object>(0);

        /// <summary>
        ///     Gets or sets the asset runtime.
        /// </summary>
        [JsonPropertyName("runtime")]
        public int? Runtime { get; set; }

        /// <summary>
        ///     Gets or sets the asset production year.
        /// </summary>
        [JsonPropertyName("productionYear")]
        public int? ProductionYear { get; set; }

        /// <summary>
        ///     Gets or sets the asset number.
        /// </summary>
        [JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        ///     Gets or sets the asset total.
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        ///     Gets or sets the asset release date.
        /// </summary>
        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; } = string.Empty;
    }
}