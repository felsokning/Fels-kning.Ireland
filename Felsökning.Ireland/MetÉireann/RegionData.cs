//-----------------------------------------------------------------------
// <copyright file="RegionData.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RegionData"/> class.
    /// </summary>
    public class RegionData
    {
        /// <summary>
        ///     Gets or sets the <see cref="Region"/>
        /// </summary>
        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Region { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the <see cref="Issued"/>
        /// </summary>
        [JsonPropertyName("issued")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? Issued { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="Today"/>
        /// </summary>
        [JsonPropertyName("today")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Today { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the <see cref="Tonight"/>
        /// </summary>
        [JsonPropertyName("tonight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Tonight { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the <see cref="Tomorrow"/>
        /// </summary>
        [JsonPropertyName("tomorrow")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Tomorrow { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the <see cref="Outlook"/>
        /// </summary>
        [JsonPropertyName("outlook")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Outlook { get; set; } = string.Empty;
    }
}