//-----------------------------------------------------------------------
// <copyright file="StructuredDuid.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StructuredDuid"/> class.
    /// </summary>
    public class StructuredDuid
    {
        /// <summary>
        ///     Gets or sets the structured duid struct tag.
        /// </summary>
        [JsonPropertyName("structTag")]
        public int StructTag { get; set; }

        /// <summary>
        ///     Gets or sets the structured duid duid.
        /// </summary>
        [JsonPropertyName("duid")]
        public string Duid { get; set; } = string.Empty;
    }
}