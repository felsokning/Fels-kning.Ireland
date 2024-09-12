//-----------------------------------------------------------------------
// <copyright file="StopResult.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StopResult"/> class.
    /// </summary>
    public class StopResult
    {
        [JsonPropertyName("stops")]
        public List<Stop> Stops { get; set; }
    }
}