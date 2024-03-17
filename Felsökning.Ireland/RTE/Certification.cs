//-----------------------------------------------------------------------
// <copyright file="Certification.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Certification"/> class.
    /// </summary>
    public class Certification
    {
        /// <summary>
        ///     Gets or sets the British Board of Film Classification (BBFC)
        /// </summary>
        [JsonPropertyName("bbfc")]
        public string Bbfc { get; set; } = string.Empty;
    }
}