//-----------------------------------------------------------------------
// <copyright file="ITripsWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ITripsWrapper"/> interface.
    /// </summary>
    public interface ITripsWrapper
    {
        /// <summary>
        ///     Gets the list of stops for a given city.
        /// </summary>
        /// <param name="city">The city to target for filtering.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        Task<List<Stop>> GetStopsForCityAsync(string city);

        /// <summary>
        ///     Gets the list of trips for a given stop.
        ///     <para>The query is for 8 hours' time-window.</para>
        /// </summary>
        /// <param name="stopId">The id of the stop.</param>
        /// <returns></returns>
        Task<List<Trip>> GetTripsForStopAsync(string stopId);
    }
}