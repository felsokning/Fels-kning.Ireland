//-----------------------------------------------------------------------
// <copyright file="MultilingualDirectionText.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MultilingualDirectionText"/> class.
    /// </summary>
    public class MultilingualDirectionText
    {
        /// <summary>
        ///     Gets or sets the default value.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public string DefaultValue { get; set; } = string.Empty;
    }
}