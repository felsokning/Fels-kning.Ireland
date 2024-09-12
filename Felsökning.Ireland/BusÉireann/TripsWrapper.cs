//-----------------------------------------------------------------------
// <copyright file="TripsWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TripsWrapper"/> class,
    ///     which is used to wrap calls to Bus Eireann's new Graph QL API.
    /// </summary>
    public class TripsWrapper : HttpBase, ITripsWrapper
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TripsWrapper"/> class,
        ///     which is used to wrap calls to Bus Eireann's new Graph QL API.
        /// </summary>
        /// <param name="apiToken">The token for the API.</param>
        public TripsWrapper(string apiToken)
            : base(HttpVersion.Version11, "Felsökning.Ireland")
        {
            this.HttpClient.DefaultRequestHeaders.Add("X-Api-Key", apiToken);
        }

        /// <summary>
        ///     Gets the list of stops for a given city.
        /// </summary>
        /// <param name="city">The city to target for filtering.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<List<Stop>> GetStopsForCityAsync(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                throw new InvalidOperationException("Cannot get stops for null/empty/whitespace.");
            }

            var stopsUlr = "https://api.buseireann.ie/stops";
            var stopResult = await this.HttpClient.GetAsync<StopResult>(stopsUlr);
            var stopResultStops = stopResult.Stops;
            var targetStops = stopResultStops.FindAll(x => x.City.Contains(city));
            return targetStops;
        }

        /// <summary>
        ///     Gets the list of trips for a given stop.
        ///     <para>The query is for 8 hours' time-window.</para>
        /// </summary>
        /// <param name="stopId">The id of the stop.</param>
        /// <returns></returns>
        public async Task<List<Trip>> GetTripsForStopAsync(string stopId)
        {
            if (string.IsNullOrEmpty(stopId))
            {
                throw new InvalidOperationException("Cannot get trips for null/empty/whitespace stop.");
            }

            var startTime = Math.Round((DateTime.UtcNow - DateTime.UnixEpoch).TotalSeconds, 0);
            var endTime = Math.Round((DateTime.UtcNow.AddHours(8) - DateTime.UnixEpoch).TotalSeconds, 0);
            var url = $"https://api.buseireann.ie/stops/{stopId}/trips?fromTime={startTime}&toTime={endTime}";
            var result = await this.HttpClient.GetAsync<TripResult>(url);
            return result.Trips;
        }
    }
}