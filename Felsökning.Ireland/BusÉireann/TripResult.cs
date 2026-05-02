//-----------------------------------------------------------------------
// <copyright file="StructuredDuid.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TripResult"/> class.
    /// </summary>
    public class TripResult
    {
        /// <summary>
        /// The trip stop metadata for the result.
        /// </summary>
        [JsonPropertyName("stop")]
        public TripStop Stop { get; set; } = new TripStop();

        /// <summary>
        /// The list of trips for the requested stop/time window.
        /// </summary>
        [JsonPropertyName("trips")]
        public List<Trip> Trips { get; set; } = new List<Trip>();
    }
}