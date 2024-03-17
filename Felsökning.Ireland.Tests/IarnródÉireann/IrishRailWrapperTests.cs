// ----------------------------------------------------------------------
// <copyright file="IrishRailWrapperTests.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests.IarnródÉireann
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class IrishRailWrapperTests
    {
        [TestMethod]
        public void IrishRailWrapper_ctor()
        {
            var sut = new IrishRailWrapper();

            sut.Should().NotBeNull();
        }

        [TestMethod]
        public void IrishRailWrapper_GetAllStations_ShouldSucceed()
        {
            var sut = new IrishRailWrapper();

            var results = sut.GetAllStations(); // Need to research overloading Xml.Load with a handler
            results.Should().NotBeNull();
            results.Count().Should().BeGreaterThanOrEqualTo(0);
        }

        [TestMethod]
        public void IrishRailWrapper_GetCurrentStationDataByDesc_ShouldSucceed()
        {
            var sut = new IrishRailWrapper();

            var results = sut.GetAllStations(); // Need to research overloading Xml.Load with a handler
            results.Should().NotBeNull();
            results.Count().Should().BeGreaterThanOrEqualTo(0);

            var station = results.FirstOrDefault(x => x.StationDesc.Contains("Portlaoise"));
            station!.StationAlias.Should().NotBeNull();
            station.StationLatitude.Should().BeGreaterThan(0);
            station.StationLongitude.Should().BeGreaterThan(-360);
            station.StationCode.Should().NotBeNullOrWhiteSpace();
            station.StationId.Should().BeGreaterThan(0);

            var stationData = sut.GetCurrentStationDataByDesc(station!.StationDesc);

            var timeUtc = DateTime.UtcNow.AddMinutes(2);
            var gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            var gmtTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, gmtTimeZone);

            stationData.Should().NotBeNull();
            stationData.Count().Should().BeGreaterThanOrEqualTo(0);
            var data = stationData.FirstOrDefault();
            data.Should().NotBeNull();
            data?.Direction.Should().NotBeNullOrWhiteSpace();
            data?.Destination.Should().NotBeNullOrWhiteSpace();
            data?.Destinationtime.Should().NotBeNullOrWhiteSpace();
            data?.Duein.Should().BeOfType(typeof(byte));
            data?.Exparrival.Should().NotBeNull();
            data?.Expdepart.Should().NotBeNull();
            data?.Late.Should().BeOfType(typeof(sbyte));
            data?.Locationtype.Should().NotBeNullOrWhiteSpace();
            data?.Origin.Should().NotBeNullOrWhiteSpace();
            data?.Origintime.Should().NotBeNullOrWhiteSpace();
            data?.Destinationtime.Should().NotBeNullOrWhiteSpace();
            data?.Querytime.Should().NotBeAfter(gmtTime);
            data?.Scharrival.Should().NotBeNullOrWhiteSpace();
            data?.Schdepart.Should().NotBeNullOrWhiteSpace();
            data?.Servertime.Should().NotBeAfter(gmtTime);
            data?.Stationcode.Should().NotBeNull();
            data?.Stationfullname.Should().NotBeNullOrWhiteSpace();
            data?.Traincode.Should().NotBeNullOrWhiteSpace();
            data?.Traindate.Should().NotBeNullOrWhiteSpace();
            data?.Traintype.Should().NotBeNullOrWhiteSpace();
        }
    }
}