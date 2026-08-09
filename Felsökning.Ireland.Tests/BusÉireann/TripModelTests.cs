//-----------------------------------------------------------------------
// <copyright file="TripModelTests.cs" company="Felskningen">
//     Copyright (c) Felskningen. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests.BusÉireann;

[TestClass]
[ExcludeFromCodeCoverage]
public class TripModelTests
{
    private string _fullTripJsonResult;
    private string _basicTripJsonResult;
    private string _partialTripJsonResult;

    [TestInitialize]
    public void Setup()
    {
        // Full trip result JSON with all properties populated including live data chain
        _fullTripJsonResult = @"{
            ""stop"": { ""id"": ""1"", ""stop_id"": ""S1"" },
            ""trips"": [{
                ""trip_id"": ""TRIP-123"",
                ""route_code"": ""46X"",
                ""route_name"": ""Dublin - Galway"",
                ""trip_headsign"": ""Galway"",
                ""trip_stop_arrival_time"": ""14:30:00"",
                ""trip_stop_departure_time"": ""14:32:00"",
                ""departure_time_raw"": 918065400,
                ""arrival_time_raw"": 918065100,
                ""gtfs_file_id"": 42,
                ""stop_id"": ""STOP-789"",
                ""trip_short_name"": ""46X"",
                ""trip_stop_sequence"": 3,
                ""trip_direction_id"": 1,
                ""trip_service_id"": 5001,
                ""monday"": true,
                ""tuesday"": true,
                ""wednesday"": true,
                ""thursday"": true,
                ""friday"": true,
                ""saturday"": false,
                ""sunday"": false,
                ""first_stop_time_raw"": 918064800,
                ""last_stop_id"": ""LAST-STOP"",
                ""departure_date"": ""2025-03-15"",
                ""trip_date"": ""2025-03-15"",
                ""departure_at"": ""2025-03-15T14:30:00Z"",
                ""trip_departure_at"": ""2025-03-15T14:32:00Z"",
                ""has_live_data"": true,
                ""live_data"": {
                    ""basic_status"": {
                        ""arrival_delay_in_seconds"": 120,
                        ""departure_delay_in_seconds"": 60,
                        ""status"": ""delayed"",
                        ""expected_arrival_time"": ""14:35:00"",
                        ""expected_departure_time"": ""14:37:00"",
                        ""expected_arrival_date_time"": ""2025-03-15T14:35:00Z"",
                        ""expected_departure_date_time"": ""2025-03-15T14:37:00Z""
                    }
                },
                ""vehicle_id"": ""BUS-99""
            }]
        }";

        // Basic trip with no live data, weekend schedule
        _basicTripJsonResult = @"{
            ""stop"": { ""id"": ""2"", ""stop_id"": ""S2"" },
            ""trips"": [{
                ""trip_id"": ""TRIP-WEEKEND"",
                ""route_code"": ""75"",
                ""route_name"": ""Weekend Express"",
                ""trip_headsign"": ""Sligo"",
                ""trip_stop_arrival_time"": ""09:00:00"",
                ""trip_stop_departure_time"": ""09:02:00"",
                ""departure_time_raw"": 800000,
                ""arrival_time_raw"": 799000,
                ""gtfs_file_id"": 10,
                ""stop_id"": ""STOP-ABC"",
                ""trip_short_name"": ""75-WKND"",
                ""trip_stop_sequence"": 1,
                ""trip_direction_id"": 2,
                ""trip_service_id"": 6001,
                ""monday"": false,
                ""tuesday"": false,
                ""wednesday"": false,
                ""thursday"": false,
                ""friday"": false,
                ""saturday"": true,
                ""sunday"": true,
                ""first_stop_time_raw"": 798000,
                ""last_stop_id"": ""LAST-WKND"",
                ""departure_date"": ""2025-04-12"",
                ""trip_date"": ""2025-04-12"",
                ""departure_at"": ""2025-04-12T09:00:00Z"",
                ""trip_departure_at"": ""2025-04-12T09:02:00Z"",
                ""has_live_data"": false,
                ""vehicle_id"": """"
            }]
        }";

        // Minimal partial trip - only required fields
        _partialTripJsonResult = @"{
            ""stop"": { ""id"": ""3"", ""stop_id"": ""S3"" },
            ""trips"": [{
                ""trip_id"": ""MINIMAL-TRIP""
            }]
        }";
    }

    [TestMethod]
    public void DeserializeFullTripResult_TripPropertiesPopulate()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_fullTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        tripResult.Should().NotBeNull();
        tripResult.Trips.Should().HaveCount(1);

        var trip = tripResult.Trips[0];
        trip.TripId.Should().Be("TRIP-123");
        trip.RouteCode.Should().Be("46X");
        trip.RouteName.Should().Be("Dublin - Galway");
        trip.TripHeadsign.Should().Be("Galway");
    }

    [TestMethod]
    public void DeserializeFullTripResult_TimePropertiesPopulate()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_fullTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.TripStopArrivalTime.Should().Be("14:30:00");
        trip.TripStopDepartureTime.Should().Be("14:32:00");
        trip.DepartureTimeRaw.Should().Be(918065400);
        trip.ArrivalTimeRaw.Should().Be(918065100);
        trip.FirstStopTimeRaw.Should().Be(918064800);
        trip.DepartureDate.Should().Be("2025-03-15");
        trip.TripDate.Should().Be("2025-03-15");
        trip.DepartureAt.Should().Be("2025-03-15T14:30:00Z");
        trip.TripDepartureAt.Should().Be("2025-03-15T14:32:00Z");
    }

    [TestMethod]
    public void DeserializeFullTripResult_NumericPropertiesPopulate()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_fullTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.GtfsFileId.Should().Be(42);
        trip.TripStopSequence.Should().Be(3);
        trip.TripDirectionId.Should().Be(1);
        trip.TripServiceId.Should().Be(5001);
    }

    [TestMethod]
    public void DeserializeFullTripResult_WeekdayFlagsPopulate()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_fullTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.Monday.Should().BeTrue();
        trip.Tuesday.Should().BeTrue();
        trip.Wednesday.Should().BeTrue();
        trip.Thursday.Should().BeTrue();
        trip.Friday.Should().BeTrue();
        trip.Saturday.Should().BeFalse();
        trip.Sunday.Should().BeFalse();
    }

    [TestMethod]
    public void DeserializeWeekendTrip_WeekendFlagsPopulate()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_basicTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.Monday.Should().BeFalse();
        trip.Tuesday.Should().BeFalse();
        trip.Wednesday.Should().BeFalse();
        trip.Thursday.Should().BeFalse();
        trip.Friday.Should().BeFalse();
        trip.Saturday.Should().BeTrue();
        trip.Sunday.Should().BeTrue();
    }

    [TestMethod]
    public void DeserializeFullTripResult_LiveDataChainPopulates()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_fullTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.HasLiveData.Should().BeTrue();
        trip.LiveData.Should().NotBeNull();
        trip.VehicleId.Should().Be("BUS-99");

        // LiveData -> BasicStatus chain
        trip.LiveData.BasicStatus.Should().NotBeNull();
        trip.LiveData.BasicStatus.ArrivalDelayInSeconds.Should().Be(120);
        trip.LiveData.BasicStatus.DepartureDelayInSeconds.Should().Be(60);
        trip.LiveData.BasicStatus.Status.Should().Be("delayed");
        trip.LiveData.BasicStatus.ExpectedArrivalTime.Should().Be("14:35:00");
        trip.LiveData.BasicStatus.ExpectedDepartureTime.Should().Be("14:37:00");
    }

    [TestMethod]
    public void DeserializeFullTripResult_BasicStatusDateTimePopulate()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_fullTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var bs = tripResult!.Trips[0].LiveData.BasicStatus;
        bs.ExpectedArrivalDateTime.Should().NotBe(default);
        bs.ExpectedDepartureDateTime.Should().NotBe(default);
        bs.ExpectedArrivalDateTime.Year.Should().BeGreaterOrEqualTo(2025);
    }

    [TestMethod]
    public void DeserializeWeekendTrip_NoLiveDataHasFalse()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_basicTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.HasLiveData.Should().BeFalse();
        trip.VehicleId.Should().BeEmpty();
    }

    [TestMethod]
    public void DeserializeMinimalTrip_DefaultValuesUsed()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_partialTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.TripId.Should().Be("MINIMAL-TRIP");
        trip.RouteCode.Should().BeEmpty();
        trip.RouteName.Should().BeEmpty();
        trip.DepartureTimeRaw.Should().Be(0);
        trip.GtfsFileId.Should().Be(0);
        trip.Monday.Should().BeFalse();
        trip.LiveData.Should().NotBeNull();
    }

    [TestMethod]
    public void DeserializeFullTripResult_StopAndStopIdsPopulate()
    {
        var tripResult = JsonSerializer.Deserialize<TripResult>(_fullTripJsonResult, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var trip = tripResult!.Trips[0];
        trip.StopId.Should().Be("STOP-789");
        trip.LastStopId.Should().Be("LAST-STOP");
        trip.TripShortName.Should().Be("46X");
    }
}
