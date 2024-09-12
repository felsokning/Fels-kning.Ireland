//-----------------------------------------------------------------------
// <copyright file="StopPassageTdiResponse.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StopPassageTdiResponse"/> class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class StopPassageTdiResponse
    {
        /// <summary>
        ///     Gets or sets the stop passage TDI of the Stop Passage TDI Response.
        /// </summary>
        [JsonPropertyName("stopPassageTdi")]
        public StopPassageTdi StopPassageTdi { get; set; } = new StopPassageTdi();
    }
}