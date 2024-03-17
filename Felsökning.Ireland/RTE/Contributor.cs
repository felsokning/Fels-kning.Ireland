//-----------------------------------------------------------------------
// <copyright file="Contributor.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Contributor"/> class.
    /// </summary>
    public class Contributor
    {
        /// <summary>
        ///     Gets or sets the contributor id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the contributor id.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the contributor metadata.
        /// </summary>
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } = new Meta();

        /// <summary>
        ///     Gets or sets the contributor media.
        /// </summary>
        [JsonPropertyName("media")]
        public List<Medium> Media { get; set; } = new List<Medium>(0);

        /// <summary>
        ///     Gets or sets the contributor subjects.
        /// </summary>
        [JsonPropertyName("subject")]
        public List<Subject> Subject { get; set; } = new List<Subject>(0);

        /// <summary>
        ///     Gets or sets the contributor characters.
        /// </summary>
        [JsonPropertyName("character")]
        public List<Character> Character { get; set; } = new List<Character>(0);

        /// <summary>
        ///     Gets or sets the contributor role.
        /// </summary>
        [JsonPropertyName("role")]
        public List<string> Role { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the contributor date of birth.
        /// </summary>
        [JsonPropertyName("dob")]
        public string Dob { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the contributor from.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the contributor's gender.
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; } = string.Empty;
    }
}