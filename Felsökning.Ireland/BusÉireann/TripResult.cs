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
        [JsonPropertyName("stop")]
        public TripStop Stop { get; set; }

        [JsonPropertyName("trips")]
        public List<Trip> Trips { get; set; }
    }
}