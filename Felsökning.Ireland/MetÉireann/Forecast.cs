//-----------------------------------------------------------------------
// <copyright file="Forecast.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Forecast"/> class.
    /// </summary>
    public class Forecast
    {
        /// <summary>
        ///     Gets or sets a <see cref="List{T}"/> of <see cref="RegionData"/>.
        /// </summary>
        [JsonPropertyName("regions")]
        public List<RegionData> Regions { get; set; } = new List<RegionData>(0);
    }
}