//-----------------------------------------------------------------------
// <copyright file="TestingHttpMessageHandler.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TestingHttpMessageHandler"/> class,
    ///     which is used to model HTTP Response messages back to the caller, based on URL.
    /// </summary>
    /// <inheritdoc cref="HttpMessageHandler"/>
    [ExcludeFromCodeCoverage]
    internal class TestingHttpMessageHandler : HttpMessageHandler
    {
        /// <summary>
        ///     Overrides the <see cref="SendAsync(HttpRequestMessage, CancellationToken)"/> method in <see cref="HttpMessageHandler"/>
        ///     to return a specified <see cref="HttpResponseMessage"/>, based on the URL called.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A <see cref="Task{TResult}"/> of <see cref="HttpResponseMessage"/> for the test class[es] to consume.</returns>
        /// <exception cref="HttpRequestException">A response to mock exceptions thrown on request.</exception>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();

            if (request?.RequestUri?.AbsoluteUri == "https://prodapi.metweb.ie/observations/Dublin/today")
            {
                responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
                responseMessage.StatusCode = HttpStatusCode.OK;
                responseMessage.Content = new StringContent(JsonSerializer.Serialize(new List<Observation>
                {
                    new Observation
                    {
                        Name = "Dublin Airport",
                        Temperature = "14",
                        Symbol = "04n",
                        WeatherDescription = "Cloudy",
                        Text = "\"Cloudy\"",
                        WindSpeed = "11",
                        WindGust = "-",
                        CardinalWindDirection = "NE",
                        WindDirection = 45,
                        Humidity = "87",
                        Rainfall = "0.0",
                        Pressure = "1019",
                        DayName = "Friday",
                        Date = "02-09-2022",
                        ReportTime = "00:00",
                    }
                }));

                return Task<HttpResponseMessage>.Factory.StartNew(() => responseMessage, cancellationToken);
            }

            throw new HttpRequestException("Resource Not Found", null, System.Net.HttpStatusCode.NotFound);
        }
    }
}