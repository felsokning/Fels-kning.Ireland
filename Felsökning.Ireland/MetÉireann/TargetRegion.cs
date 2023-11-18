//-----------------------------------------------------------------------
// <copyright file="ForecastsForRegion.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TargetRegion"/> enumeration.
    /// </summary>
    public enum TargetRegion
    {
        /// <summary>
        ///     Connacht
        /// </summary>
        [EnumMember(Value = "Connacht ")]
        [JsonPropertyName("Connacht ")]
        Connacht,

        /// <summary>
        ///     Connacht
        /// </summary>
        [EnumMember(Value = "Dublin ")]
        [JsonPropertyName("Dublin ")]
        Dublin,

        /// <summary>
        ///     Connacht
        /// </summary>
        [EnumMember(Value = "Connacht ")]
        [JsonPropertyName("Connacht ")]
        Leinster,

        /// <summary>
        ///     Connacht
        /// </summary>
        [EnumMember(Value = "Connacht ")]
        [JsonPropertyName("Connacht ")]
        Munster,

        /// <summary>
        ///     Connacht
        /// </summary>
        [EnumMember(Value = "Connacht ")]
        [JsonPropertyName("Connacht ")]
        Ulster,
    }
}