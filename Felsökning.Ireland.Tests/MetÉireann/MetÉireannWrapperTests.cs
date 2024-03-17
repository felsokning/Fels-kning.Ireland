//-----------------------------------------------------------------------
// <copyright file="MetÉireannWrapperTests.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests.MetÉireann
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class MetÉireannWrapperTests
    {
        [TestMethod]
        public void MetÉireannWrapper_ctor()
        {
            var sut = new MetÉireannWrapper();

            sut.Should().NotBeNull();
            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version20);
            sut.HttpClient.DefaultRequestHeaders.Accept.FirstOrDefault().Should().NotBeNull();
        }

        [TestMethod]
        public async Task MetÉireannWrapper_GetRecentObservationsAsync_ShouldSucceed()
        {

            var sut = new MetÉireannWrapper()
            {
                HttpClient = new HttpClient(new TestingHttpMessageHandler())
            };

            var results = await sut.GetRecentObservationsAsync(City.Dublin);

            results.Should().NotBeEmpty();
            results.Should().HaveCount(1);
            var observation = results[0];
            observation.Name.Should().Be("Dublin Airport");

            sut = new MetÉireannWrapper
            {
                HttpClient = new HttpClient(new TestingHttpMessageHandler())
            };

            results = await sut.GetRecentObservationsAsync(City.Dublin);

            results.Should().NotBeEmpty();
            results.Should().HaveCount(1);
            observation = results[0];
            observation.Name.Should().Be("Dublin Airport");
        }

        [TestMethod]
        public async Task MetÉireannWrapper_GetRecentObservationsAsync_Real_ShouldSucceed()
        {

            var sut = new MetÉireannWrapper();

            var results = await sut.GetRecentObservationsAsync(City.Dublin);

            results.Should().NotBeEmpty();
            results.Should().HaveCountGreaterThan(0);
            var observation = results[0];
            observation.Name.Should().Be("Dublin Airport");
        }

        [TestMethod]
        public async Task MetÉireannWrapper_GetRecentObservationsAsync_ShouldThrowStatusException()
        {
            var sut = new MetÉireannWrapper()
            {
                HttpClient = new HttpClient(new TestingHttpMessageHandler())
            };

            var exception = await Assert.ThrowsExceptionAsync<StatusException>(async () => await sut.GetRecentObservationsAsync(City.Athenry));

            exception.Should().NotBeNull();
            exception.Should().BeOfType<StatusException>();
            var innerException = exception.InnerException;
            innerException.Should().BeOfType<HttpRequestException>();
        }

        [TestMethod]
        public async Task MetÉireannWrapper_GetForecastForRegionAsync_Real_ShouldSucceed()
        {
            var sut = new MetÉireannWrapper();

            var results = await sut.GetForecastForRegionAsync(TargetRegion.Connacht);

            results.Should().NotBeNull();
            results.Forecasts.Should().HaveCountGreaterThan(0);
            results.Forecasts[0].Regions[0].Region.Should().NotBeNullOrWhiteSpace();
        }
    }
}