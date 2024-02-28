//-----------------------------------------------------------------------
// <copyright file="Observation.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Observation"/> class.
    /// </summary>
    public class Observation
    {
        /// <summary>
        ///     Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     Dry bulb temperature in whole degrees
        /// </summary>
        [JsonPropertyName("temperature")]
        public string Temperature { get; set; } = string.Empty;

        /// <summary>
        ///     The Temperature Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        ///     Weather description
        /// </summary>
        [JsonPropertyName("weatherDescription")]
        public string WeatherDescription { get; set; } = string.Empty;

        /// <summary>
        ///     Text Included with the Observation.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        ///     Windspeed (kt)
        /// </summary>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; } = string.Empty;

        /// <summary>
        ///     Windgust
        /// </summary>
        [JsonPropertyName("windGust")]
        public string WindGust { get; set; } = string.Empty;

        /// <summary>
        ///     Cardinal Wind Direction
        /// </summary>
        [JsonPropertyName("cardinalWindDirection")]
        public string CardinalWindDirection { get; set; } = string.Empty;

        /// <summary>
        ///     Wind Direction
        /// </summary>
        [JsonPropertyName("windDirection")]
        public int WindDirection { get; set; }

        /// <summary>
        ///     Humidity (%)
        /// </summary>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; } = string.Empty;

        /// <summary>
        ///     Rainfall (mm)
        /// </summary>
        [JsonPropertyName("rainfall")]
        public string Rainfall { get; set; } = string.Empty;

        /// <summary>
        ///     msl Pressure (mbar)
        /// </summary>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; } = string.Empty;

        /// <summary>
        ///     Name of the day of the observation
        /// </summary>
        [JsonPropertyName("dayName")]
        public string DayName { get; set; } = string.Empty;

        /// <summary>
        ///     Date of the observation
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; } = string.Empty;

        /// <summary>
        ///     The time the observation was reported.
        /// </summary>
        [JsonPropertyName("reportTime")]
        public string ReportTime { get; set; } = string.Empty;
    }
}