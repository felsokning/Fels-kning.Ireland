//-----------------------------------------------------------------------
// <copyright file="LiveData.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="LiveData"/> class.
    /// </summary>
    public class LiveData
    {
        /// <summary>
        /// Basic status information for the trip (delays, expected times).
        /// </summary>
        [JsonPropertyName("basic_status")]
        public BasicStatus BasicStatus { get; set; } = new BasicStatus();
    }
}