//-----------------------------------------------------------------------
// <copyright file="Subject.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Subject"/> class.
    /// </summary>
    public class Subject
    {
        /// <summary>
        ///     Gets or sets the subject code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the subject profile.
        /// </summary>
        [JsonPropertyName("profile")]
        public string Profile { get; set; } = string.Empty;
    }
}