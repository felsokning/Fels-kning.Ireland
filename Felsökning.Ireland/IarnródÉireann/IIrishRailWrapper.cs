// ----------------------------------------------------------------------
// <copyright file="IIrishRailWrapper.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Ireland.IarnródÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IIrishRailWrapper"/> class.
    /// </summary>
    public interface IIrishRailWrapper
    {
        /// <summary>
        ///     Obtains all of the Railway Stations from the Irish Rail API.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{ObjStation}"/> of <see cref="ObjStation"/></returns>
        IEnumerable<ObjStation> GetAllStations();

        /// <summary>
        ///     Obtains all of the Railway Station data from the Irish Rail API.
        /// </summary>
        /// <param name="stationDesc">A station description obtained from an <see cref="ObjStation"/> object.</param>
        /// <returns>An <see cref="IEnumerable{ObjStationData}"/> of <see cref="ObjStationData"/></returns>
        IEnumerable<ObjStationData> GetCurrentStationDataByDesc(string stationDesc);
    }
}