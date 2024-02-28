// ----------------------------------------------------------------------
// <copyright file="IrishRailWrapper.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Ireland.IarnródÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrishRailWrapper"/> class.
    /// </summary>
    /// <inheritdoc cref="IIrishRailWrapper"/>
    public class IrishRailWrapper : IIrishRailWrapper
    {
        private readonly XmlDocument XmlDocument;
        private readonly XmlSerializer XmlStationDataSerializer;
        private readonly XmlSerializer XmlStationSerializer;

        /// <summary>
        ///     Initializes a new instance of the <see cref="IrishRailWrapper"/> class.
        /// </summary>
        public IrishRailWrapper()
        {
            this.XmlDocument = new XmlDocument();
            this.XmlStationDataSerializer = new XmlSerializer(typeof(ArrayOfObjStationData));
            this.XmlStationSerializer = new XmlSerializer(typeof(ArrayOfObjStation));
        }

        /// <summary>
        ///     Obtains all of the Railway Stations from the Irish Rail API.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{ObjStation}"/> of <see cref="ObjStation"/></returns>
        public IEnumerable<ObjStation> GetAllStations()
        {
            this.XmlDocument.Load("https://api.irishrail.ie/realtime/realtime.asmx/getAllStationsXML");
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(this.XmlDocument.InnerXml));
            var xmlReader = XmlReader.Create(memoryStream);
            var result = this.XmlStationSerializer.Deserialize(xmlReader) as ArrayOfObjStation;
            return result.objStation;
        }

        /// <summary>
        ///     Obtains all of the Railway Station data from the Irish Rail API.
        /// </summary>
        /// <param name="stationDesc">A station description obtained from an <see cref="ObjStation"/> object.</param>
        /// <returns>An <see cref="IEnumerable{ObjStationData}"/> of <see cref="ObjStationData"/></returns>
        public IEnumerable<ObjStationData> GetCurrentStationDataByDesc(string stationDesc)
        {
            this.XmlDocument.Load($"https://api.irishrail.ie/realtime/realtime.asmx/getStationDataByNameXML?StationDesc={stationDesc}");
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(this.XmlDocument.InnerXml));
            var xmlReader = XmlReader.Create(memoryStream);
            var result = this.XmlStationDataSerializer.Deserialize(xmlReader) as ArrayOfObjStationData;
            return result.objStationData;
        }
    }
}