namespace Felsökning.Ireland.Tests.BusÉireann
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class StopWrapperTests
    {
        [TestMethod]
        public void ctor()
        {
            var stopWrapper = new StopWrapper();

            stopWrapper.Should().NotBeNull();
            stopWrapper.Should().BeOfType<StopWrapper>();
        }

        [TestMethod]
        public async Task GetStopsForGeoLocationAsync_Succeeds()
        {
            var stopWrapper = new StopWrapper();
            await stopWrapper.GetStopsForGeoLocationAsync("193964652", "193892652", "-31822056", "-31894056");

            stopWrapper.Should().NotBeNull();

            stopWrapper.BusStops.Should().HaveCountGreaterThanOrEqualTo(4); // Should never be 0 for testing.
        }

        [TestMethod]
        public async Task GetPassagesForStopsAsync_Fails_No_BusStops()
        {
            var stopWrapper = new StopWrapper();
            var exception = await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () => await stopWrapper.GetPassagesForStopsAsync());

            exception.Should().BeOfType<InvalidOperationException>();
        }

        [TestMethod]
        public async Task GetPassagesForStopsAsync_Succeeds()
        {
            var stopWrapper = new StopWrapper();
            await stopWrapper.GetStopsForGeoLocationAsync("193964652", "193892652", "-31822056", "-31894056");

            var results = await stopWrapper.GetPassagesForStopsAsync();
            results.Should().NotBeNull();
            results.Should().BeOfType<List<CorrelatedPassages>>();
            foreach (var result in results)
            {
                foreach (var passage in result.Passages)
                {
                    Trace.WriteLine($"Bus Stop: {result.BusStop.LongName} Scheduled Arrival: {passage.ArrivalData.ScheduledPassageTimeUtc} From: {passage.ArrivalData.MultilingualDirectionText.DefaultValue} Scheduled Departure: {passage.DepartureData.ScheduledPassageTimeUtc} To: {passage.DepartureData.MultilingualDirectionText.DefaultValue}");
                }
            }
        }
    }
}