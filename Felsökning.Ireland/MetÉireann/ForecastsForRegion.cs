//-----------------------------------------------------------------------
// <copyright file="ForecastsForRegion.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ForecastsForRegion"/> class.
    /// </summary>
    public class ForecastsForRegion
    {
        /// <summary>
        ///     Gets or sets a <see cref="List{T}"/> of <see cref="Forecast"/>
        /// </summary>
        [JsonPropertyName("forecasts")]
        public List<Forecast> Forecasts { get; set; } = new List<Forecast>(0);
    }
}