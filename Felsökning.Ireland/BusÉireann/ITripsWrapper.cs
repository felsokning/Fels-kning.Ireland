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
        Task<List<Trip>> GetTripsForStopAsync(string stopId);
    }
}