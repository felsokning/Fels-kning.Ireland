//-----------------------------------------------------------------------
// <copyright file="City.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.MetÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="City"/> enumerable.
    /// </summary>
    public enum City
    {
        /// <summary>
        ///     Athenry, Co Galway
        /// </summary>
        [EnumMember(Value = "athenry")]
        [JsonPropertyName("athenry")]
        Athenry,

        /// <summary>
        ///     Ballyhaise, Co Cavan
        /// </summary>
        [EnumMember(Value = "ballyhaise")]
        [JsonPropertyName("ballyhaise")]
        Ballyhaise,

        /// <summary>
        ///     Belmullet, Co Mayo
        /// </summary>
        [EnumMember(Value = "belmullet")]
        [JsonPropertyName("belmullet")]
        Belmullet,

        /// <summary>
        ///     Casement Aerodrome, Dublin
        /// </summary>
        [EnumMember(Value = "casement")]
        [JsonPropertyName("casement")]
        Casement,

        /// <summary>
        ///     Claremorris, Co Mayo
        /// </summary>
        [EnumMember(Value = "claremorris")]
        [JsonPropertyName("claremorris")]
        Claremorris,

        /// <summary>
        ///     Cork Airport
        /// </summary>
        [EnumMember(Value = "cork")]
        [JsonPropertyName("cork")]
        Cork,

        /// <summary>
        ///     Dublin Airport
        /// </summary>
        [EnumMember(Value = "dublin")]
        [JsonPropertyName("dublin")]
        Dublin,

        /// <summary>
        ///     Dunsany, Co Meath
        /// </summary>
        [EnumMember(Value = "dunsany")]
        [JsonPropertyName("dunsany")]
        Dunsany,

        /// <summary>
        ///     Finner, Co Galway
        /// </summary>
        [EnumMember(Value = "finner")]
        [JsonPropertyName("finner")]
        Finner,

        /// <summary>
        ///     Gurteen, Co Tipperarary
        /// </summary>
        [EnumMember(Value = "gurteen")]
        [JsonPropertyName("gurteen")]
        Gurteen,

        /// <summary>
        ///     Johnstown Castle, Co Wexford
        /// </summary>
        [EnumMember(Value = "johnstown")]
        [JsonPropertyName("johnstown")]
        Johnstown,

        /// <summary>
        ///     Knock Airport, Co Mayo
        /// </summary>
        [EnumMember(Value = "knock")]
        [JsonPropertyName("knock")]
        Knock,

        /// <summary>
        ///     Mace Head, Co Galway
        /// </summary>
        [EnumMember(Value = "mace-head")]
        [JsonPropertyName("mace-head")]
        MaceHead,

        /// <summary>
        ///     Malin head, Co Donegal
        /// </summary>
        [EnumMember(Value = "malin-head")]
        [JsonPropertyName("malin-head")]
        MalinHead,

        /// <summary>
        ///     Markree, Co Sligo
        /// </summary>
        [EnumMember(Value = "Markree-Castle")]
        [JsonPropertyName("Markree-Castle")]
        MarkreeCastle,

        /// <summary>
        ///     Moore Park, Co Cork
        /// </summary>
        [EnumMember(Value = "moore-park")]
        [JsonPropertyName("moore-park")]
        MoorePark,

        /// <summary>
        ///     Mt Dillon, Co Roscommon
        /// </summary>
        [EnumMember(Value = "mt-dillon")]
        [JsonPropertyName("mt-dillon")]
        MtDillon,

        /// <summary>
        ///     Mullingar
        /// </summary>
        [EnumMember(Value = "mullingar")]
        [JsonPropertyName("mullingar")]
        Mullingar,

        /// <summary>
        ///     Newport
        /// </summary>
        [EnumMember(Value = "newport-furnace")]
        [JsonPropertyName("newport-furnace")]
        NewPort,

        /// <summary>
        ///     Oak Park
        /// </summary>
        [EnumMember(Value = "oak-park")]
        [JsonPropertyName("oak-park")]
        OakPark,

        /// <summary>
        ///     Phoenix Park
        /// </summary>
        [EnumMember(Value = "phoenix-park")]
        [JsonPropertyName("phoenix-park")]
        PhoenixPark,

        /// <summary>
        ///     Roches Point
        /// </summary>
        [EnumMember(Value = "roches-point")]
        [JsonPropertyName("roches-point")]
        RochesPoint,

        /// <summary>
        ///     Shannon Airport
        /// </summary>
        [EnumMember(Value = "shannon")]
        [JsonPropertyName("shannon")]
        Shannon,

        /// <summary>
        ///     Sherkin Island
        /// </summary>
        [EnumMember(Value = "sherkin-island")]
        [JsonPropertyName("sherkin-island")]
        SherkinIsland,

        /// <summary>
        ///     Valentia
        /// </summary>
        [EnumMember(Value = "valentia")]
        [JsonPropertyName("valentia")]
        Valentia
    }
}