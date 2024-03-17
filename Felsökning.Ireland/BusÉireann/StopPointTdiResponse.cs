//-----------------------------------------------------------------------
// <copyright file="StopPointTdiResponse.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StopPointTdiResponse"/> class.
    /// </summary>
    public class StopPointTdiResponse
    {
        /// <summary>
        ///     Gets or sets the TDI of the Stop Point TDI Response.
        /// </summary>
        [JsonPropertyName("stopPointTdi")]
        public StopPointTdi StopPointTdi { get; set; } = new StopPointTdi();
    }
}