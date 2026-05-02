// ----------------------------------------------------------------------
// <copyright file="FlightInformation.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Felsökning.Ireland.CADCO
{
    /// <summary>
    /// Flight details returned in arrivals/departures payloads.
    /// </summary>
    public class FlightInformation
    {
        /// <summary>
        /// The identifier of the operating airline.
        /// </summary>
        [JsonPropertyName("airlineId")]
        public string AirlineId { get; set; } = string.Empty;

        /// <summary>
        /// The display name of the operating airline.
        /// </summary>
        [JsonPropertyName("airlineName")]
        public string AirlineName { get; set; } = string.Empty;

        /// <summary>
        /// IATA code of the arrival airport.
        /// </summary>
        [JsonPropertyName("arrivalAirportCode")]
        public string ArrivalAirportCode { get; set; } = string.Empty;

        /// <summary>
        /// IATA code of the departure airport.
        /// </summary>
        [JsonPropertyName("departureAirportCode")]
        public string DepartureAirportCode { get; set; } = string.Empty;

        /// <summary>
        /// Display name of the arrival airport.
        /// </summary>
        [JsonPropertyName("arrivalAirportName")]
        public string ArrivalAirportName { get; set; } = string.Empty;

        /// <summary>
        /// Display name of the departure airport.
        /// </summary>
        [JsonPropertyName("departureAirportName")]
        public string DepartureAirportName { get; set; } = string.Empty;

        /// <summary>
        /// Scheduled arrival airport code (if different from the arrival code).
        /// </summary>
        [JsonPropertyName("scheduledArrivalAirportCode")]
        public string ScheduledArrivalAirportCode { get; set; } = string.Empty;

        /// <summary>
        /// Scheduled arrival airport name.
        /// </summary>
        [JsonPropertyName("scheduledArrivalAirportName")]
        public string ScheduledArrivalAirportName { get; set; } = string.Empty;

        /// <summary>
        /// The flight number.
        /// </summary>
        [JsonPropertyName("flightNumber")]
        public string FlightNumber { get; set; } = string.Empty;

        /// <summary>
        /// Scheduled arrival time as provided by the API.
        /// </summary>
        [JsonPropertyName("scheduledArrivalTime")]
        public string ScheduledArrivalTime { get; set; } = string.Empty;

        /// <summary>
        /// Localised representation of the scheduled arrival time.
        /// </summary>
        [JsonPropertyName("localisedScheduledArrivalTime")]
        public string LocalisedScheduledArrivalTime { get; set; } = string.Empty;

        /// <summary>
        /// Estimated arrival time.
        /// </summary>
        [JsonPropertyName("estimatedArrivalTime")]
        public string EstimatedArrivalTime { get; set; } = string.Empty;

        /// <summary>
        /// Localised estimated arrival time.
        /// </summary>
        [JsonPropertyName("localisedEstimatedArrivalTime")]
        public string LocalisedEstimatedArrivalTime { get; set; } = string.Empty;

        /// <summary>
        /// Arrival terminal identifier.
        /// </summary>
        [JsonPropertyName("arrivalTerminal")]
        public string ArrivalTerminal { get; set; } = string.Empty;

        /// <summary>
        /// Localised arrival terminal string.
        /// </summary>
        [JsonPropertyName("arrivalTerminalLocalised")]
        public string ArrivalTerminalLocalised { get; set; } = string.Empty;

        /// <summary>
        /// Scheduled departure time.
        /// </summary>
        [JsonPropertyName("scheduledDepartureTime")]
        public string ScheduledDepartureTime { get; set; } = string.Empty;

        /// <summary>
        /// Localised scheduled departure time.
        /// </summary>
        [JsonPropertyName("localisedScheduledDepartureTime")]
        public string LocalisedScheduledDepartureTime { get; set; } = string.Empty;

        /// <summary>
        /// Estimated departure time.
        /// </summary>
        [JsonPropertyName("estimatedDepartureTime")]
        public string EstimatedDepartureTime { get; set; } = string.Empty;

        /// <summary>
        /// Localised estimated departure time.
        /// </summary>
        [JsonPropertyName("localisedEstimatedDepartureTime")]
        public string LocalisedEstimatedDepartureTime { get; set; } = string.Empty;

        /// <summary>
        /// Departure terminal identifier.
        /// </summary>
        [JsonPropertyName("departureTerminal")]
        public string DepartureTerminal { get; set; } = string.Empty;

        /// <summary>
        /// Localised departure terminal string.
        /// </summary>
        [JsonPropertyName("departureTerminalLocalised")]
        public string DepartureTerminalLocalised { get; set; } = string.Empty;

        /// <summary>
        /// Current operational status of the flight (e.g. "Landed", "Delayed").
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Localised string for the flight status.
        /// </summary>
        [JsonPropertyName("statusLocalised")]
        public string StatusLocalised { get; set; } = string.Empty;

        /// <summary>
        /// Operator flight number (if different from the published number).
        /// </summary>
        [JsonPropertyName("opFlightNumber")]
        public string OpFlightNumber { get; set; } = string.Empty;

        /// <summary>
        /// Assigned arrival gate.
        /// </summary>
        [JsonPropertyName("arrivalGate")]
        public string ArrivalGate { get; set; } = string.Empty;

        /// <summary>
        /// Assigned boarding gate.
        /// </summary>
        [JsonPropertyName("boardingGate")]
        public string BoardingGate { get; set; } = string.Empty;

        /// <summary>
        /// Provider-specific schedule instance key (opaque).
        /// </summary>
        [JsonPropertyName("scheduleInstanceKey")]
        public object? ScheduleInstanceKey { get; set; }

        /// <summary>
        /// Any codeshare entries associated with the flight.
        /// </summary>
        [JsonPropertyName("codeshares")]
        public List<CodeShare> Codeshares { get; set; } = new List<CodeShare>();

        /// <summary>
        /// True when this flight is a codeshare.
        /// </summary>
        [JsonPropertyName("codeShare")]
        public bool IsCodeShare { get; set; }

        /// <summary>
        /// True when the flight has been diverted.
        /// </summary>
        [JsonPropertyName("isDiverted")]
        public bool IsDiverted { get; set; }
    }
}

