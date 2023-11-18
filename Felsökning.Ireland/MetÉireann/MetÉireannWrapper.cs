//-----------------------------------------------------------------------
// <copyright file="MetÉireannWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MetÉireannWrapper"/>vclass,
    ///     which is used to retrieve observations from Met Éireann.
    /// </summary>
    public class MetÉireannWrapper : HttpBase, IMetÉireannWrapper
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MetÉireannWrapper"/>vclass,
        ///     which is used to retrieve observations from Met Éireann.
        /// </summary>
        public MetÉireannWrapper()
            : base(HttpVersion.Version20, "Felsökning.Utilities.Ireland.MetÉireann")
        {
        }

        /// <summary>
        ///     Obtains the most recent Forecast for a given <see cref="TargetRegion"/>
        /// </summary>
        /// <param name="region">A valid <see cref="TargetRegion"/> forecasted by MetÉireann.</param>
        /// <returns>An awaitable <see cref="Task"/> of <see cref="ForecastsForRegion"/>.</returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<ForecastsForRegion> GetForecastForRegionAsync(TargetRegion region)
        {
            this.HttpClient.GenerateNewRequestId();
            return await this.HttpClient.GetAsync<ForecastsForRegion>($"https://www.met.ie/Open_Data/json/{region}.json");
        }

        /// <summary>
        ///     Obtains the recent observations for a given <see cref="City"/>
        /// </summary>
        /// <param name="city">A valid <see cref="City"/> monitored by MetÉireann.</param>
        /// <returns>An awaitable <see cref="Task"/> of <see cref="List{T}"/> of <see cref="Observation"/>.</returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<List<Observation>> GetRecentObservationsAsync(City city)
        {
            this.HttpClient.GenerateNewRequestId();
            return await this.HttpClient.GetAsync<List<Observation>>($"https://prodapi.metweb.ie/observations/{city}/today");
        }
    }
}