// ----------------------------------------------------------------------
// <copyright file="NocWrapperTests.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class NocWrapperTests
    {
        [TestMethod]
        public async Task NocWrapper_GetArrivalsAsync_ShouldReturnResults()
        {
            var sut = new NocWrapper();

            var arrivals = await sut.GetArrivalsAsync();

            arrivals.Should().NotBeNullOrWhiteSpace();
        }

        [TestMethod]
        public async Task NocWrapper_GetDeparturesAsync_ShouldReturnResults()
        {
            var sut = new NocWrapper();

            var departures = await sut.GetDeparturesAsync();

            departures.Should().NotBeNullOrWhiteSpace();
        }
    }
}