namespace Felsökning.Ireland.Tests.BusÉireann
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TripsWrapperTests
    {
        private TripsWrapper CreateSut()
        {
            return new TripsWrapper("UNuAnKnKEx9m0VKS0WZeE7Zr12my2ThZ9rGTWZw3");
        }

        [TestMethod]
        public void ctor()
        {
            var tripsWrapper = CreateSut();

            tripsWrapper.Should().NotBeNull();
            tripsWrapper.Should().BeOfType<TripsWrapper>();
        }

        [TestMethod]
        public async Task GetStopsForCityAsync_Fails_No_City()
        {
            var tripsWrapper = CreateSut();

            tripsWrapper.Should().NotBeNull();
            tripsWrapper.Should().BeOfType<TripsWrapper>();

            var exception = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () => await tripsWrapper.GetStopsForCityAsync(string.Empty));

            exception.Should().BeOfType<InvalidOperationException>();
            exception.Message.Should().Be("Cannot get stops for null/empty/whitespace.");
        }

        [TestMethod]
        public async Task GetTripsForStopAsync_Fails_No_Stop()
        {
            var tripsWrapper = CreateSut();

            tripsWrapper.Should().NotBeNull();
            tripsWrapper.Should().BeOfType<TripsWrapper>();

            var exception = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () => await tripsWrapper.GetTripsForStopAsync(string.Empty));

            exception.Should().BeOfType<InvalidOperationException>();
            exception.Message.Should().Be("Cannot get trips for null/empty/whitespace stop.");
        }

        [TestMethod]
        public async Task GetStopsForCityAsync_Succeeds()
        {
            var tripsWrapper = CreateSut();

            tripsWrapper.Should().NotBeNull();
            tripsWrapper.Should().BeOfType<TripsWrapper>();

            var result = await tripsWrapper.GetStopsForCityAsync("Claremorris");

            result.Should().NotBeNull();
            result.Should().BeOfType<List<Stop>>();
            result.Count().Should().BeGreaterThanOrEqualTo(0);
        }

        [TestMethod]
        public async Task GetTripsForStopAsync_Succeeds()
        {
            var tripsWrapper = CreateSut();

            tripsWrapper.Should().NotBeNull();
            tripsWrapper.Should().BeOfType<TripsWrapper>();

            var result = await tripsWrapper.GetTripsForStopAsync("532381");

            result.Should().NotBeNull();
            result.Should().BeOfType<List<Trip>>();
            result.Count().Should().BeGreaterThanOrEqualTo(0);
        }
    }
}