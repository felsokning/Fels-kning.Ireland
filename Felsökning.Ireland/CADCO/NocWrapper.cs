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
        }

        /// <summary>
        ///     Gets the Arrivals to NOC Airport as an HTML table.
        /// </summary>
        /// <returns>An HTML table body containing the Arrivals as rows.</returns>
        public async Task<string> GetArrivalsAsync()
        {
            return await this.HttpClient.GetStringAsync("https://www.irelandwestairport.com/site/getArrival");
        }

        /// <summary>
        ///     Gets the Departures to NOC Airport as an HTML table.
        /// </summary>
        /// <returns>An HTML table body containing the Departures as rows.</returns>
        public async Task<string> GetDeparturesAsync()
        {
            return await this.HttpClient.GetStringAsync("https://www.irelandwestairport.com/site/getDeparture");
        }
    }
}