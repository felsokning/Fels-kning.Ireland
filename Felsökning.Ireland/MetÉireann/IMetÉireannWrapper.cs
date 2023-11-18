//-----------------------------------------------------------------------
// <copyright file="IMetÉireannWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IMetÉireannWrapper"/> interface.
    /// </summary>
    public interface IMetÉireannWrapper
    {
        /// <summary>
        ///     Obtains the list of Observations from the prodapi.metweb.ie endpoint.
        /// </summary>
        /// <param name="city">A city which target for the API request.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Observation"/> objects.</returns>
        Task<List<Observation>> GetRecentObservationsAsync(City city);
    }
}