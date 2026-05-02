//-----------------------------------------------------------------------
// <copyright file="NocWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.CADCO
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NocWrapper"/> class.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    public class NocWrapper : HttpBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NocWrapper"/> class.
        /// </summary>
        /// <inheritdoc cref="HttpBase"/>
        public NocWrapper()
            : base(HttpVersion.Version20)
        {
            base.HttpClient.BaseAddress = new Uri("https://www.skyscanner.ie");
        }

        /// <summary>
        ///     Gets the Arrivals to NOC Airport as an HTML table.
        /// </summary>
        /// <returns>An HTML table body containing the Arrivals as rows.</returns>
        public async Task<List<FlightInformation>> GetArrivalsAsync()
        {
            var skyScannerResponse = await this.HttpClient.GetAsync<SkyScannerResponse>("/g/arrival-departure-svc/api/airports/noc/arrivals?locale=en-GB");
            return skyScannerResponse!.Arrivals;
        }

        /// <summary>
        ///     Gets the Departures to NOC Airport as an HTML table.
        /// </summary>
        /// <returns>An HTML table body containing the Departures as rows.</returns>
        public async Task<List<FlightInformation>> GetDeparturesAsync()
        {
            var skyScannerResponse = await this.HttpClient.GetAsync<SkyScannerResponse>("/g/arrival-departure-svc/api/airports/noc/departures?locale=en-GB");
            return skyScannerResponse!.Departures;
        }
    }
}