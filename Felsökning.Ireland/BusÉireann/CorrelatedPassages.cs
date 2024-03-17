//-----------------------------------------------------------------------
// <copyright file="CorrelatedPassages.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CorrelatedPassages"/> class.
    /// </summary>
    public class CorrelatedPassages
    {
        /// <summary>
        ///     Gets or sets the bus stop for the correlated passages.
        /// </summary>
        public BusStop BusStop { get; set; } = new BusStop();

        /// <summary>
        ///     Gets or sets the list of passages for the correlated passages.
        /// </summary>
        public List<Passage> Passages { get; set; } = new List<Passage>(0);
    }
}