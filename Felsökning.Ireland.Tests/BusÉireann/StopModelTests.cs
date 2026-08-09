//-----------------------------------------------------------------------
// <copyright file="StopModelTests.cs" company="Felskningen">
//     Copyright (c) Felskningen. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests.BusÉireann;

[TestClass]
[ExcludeFromCodeCoverage]
public class StopModelTests
{
    /// <summary>
    /// JSON fixture: full stop with geo coordinates and all fields populated.
    /// Covers previously untested Latitude, Longitude, and GtfsFileId properties.
    /// </summary>
    private string _fullStopJson;

    [TestInitialize]
    public void Setup()
    {
        _fullStopJson = @"{ ""stops"": [
            {
                ""id"": ""STOP-001"",
                ""stop_id"": ""DUBLIN_CONNEXION_24"",
                ""code"": ""532381"",
                ""name"": ""Connexions 24"",
                ""latitude"": 53.3498,
                ""longitude"": -6.2603,
                ""gtfs_file_id"": 77,
                ""geom"": ""POINT(-6.2603 53.3498)"",
                ""fullCode"": ""DUBLIN_532381"",
                ""ffCode"": ""FF-ABC"",
                ""ntaName"": ""Dublin NTA"",
                ""city"": ""Dublin"",
                ""weight"": 10
            }
        ]}";
    }

    [TestMethod]
    public void DeserializeStopResult_WithGeoData_LatitudePopulates()
    {
        var result = JsonSerializer.Deserialize<StopResult>(_fullStopJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        result.Should().NotBeNull();
        result.Stops.Should().HaveCount(1);
        var stop = result.Stops[0];
        stop.Latitude.Should().BeApproximately(53.3498, 0.0001, "geo data should deserialize correctly");
    }

    [TestMethod]
    public void DeserializeStopResult_WithGeoData_LongitudePopulates()
    {
        var result = JsonSerializer.Deserialize<StopResult>(_fullStopJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var stop = result!.Stops[0];
        stop.Longitude.Should().BeApproximately(-6.2603, 0.0001, "longitudes are negative for Ireland");
    }

    [TestMethod]
    public void DeserializeStopResult_GtfsFileIdPopulates()
    {
        var result = JsonSerializer.Deserialize<StopResult>(_fullStopJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var stop = result!.Stops[0];
        stop.GtfsFileId.Should().Be(77);
    }

    [TestMethod]
    public void DeserializeStopResult_AllStringPropertiesPopulate()
    {
        var result = JsonSerializer.Deserialize<StopResult>(_fullStopJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var stop = result!.Stops[0];
        stop.Id.Should().Be("STOP-001");
        stop.StopId.Should().Be("DUBLIN_CONNEXION_24");
        stop.Code.Should().Be("532381");
        stop.Name.Should().Be("Connexions 24");
        stop.Geom.Should().Be("POINT(-6.2603 53.3498)");
        stop.FullCode.Should().Be("DUBLIN_532381");
        stop.FfCode.Should().Be("FF-ABC");
        stop.NtaName.Should().Be("Dublin NTA");
        stop.City.Should().Be("Dublin");
        stop.Weight.Should().Be(10);
    }

    [TestMethod]
    public void DeserializeStopResult_MissingOptionalFields_UsesDefaults()
    {
        var minimalJson = @"{ ""stops"": [{ ""id"": ""MIN"",""name"":""Min"" }] }";

        var result = JsonSerializer.Deserialize<StopResult>(minimalJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var stop = result!.Stops[0];
        stop.Id.Should().Be("MIN");
        stop.Name.Should().Be("Min");
        stop.Latitude.Should().Be(0);
        stop.Longitude.Should().Be(0);
        stop.GtfsFileId.Should().Be(0);
        stop.Weight.Should().BeNull();
    }

    [TestMethod]
    public void DeserializeStopResult_EdgeCaseCoordinates_AtOrigin()
    {
        var originJson = @"{ ""stops"": [{ ""id"": ""O"", ""name"": ""Origin"", ""latitude"": 0, ""longitude"": 0 }] }";

        var result = JsonSerializer.Deserialize<StopResult>(originJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var stop = result!.Stops[0];
        stop.Latitude.Should().Be(0);
        stop.Longitude.Should().Be(0);
    }

    [TestMethod]
    public void DeserializeStopResult_NegativeCoordinates_CorrectlyParsed()
    {
        var negativeJson = @"{ ""stops"": [{ ""id"": ""N"", ""name"": ""North"", ""latitude"": 53.5, ""longitude"": -10.25, ""gtfs_file_id"": 99 }] }";

        var result = JsonSerializer.Deserialize<StopResult>(negativeJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var stop = result!.Stops[0];
        stop.Latitude.Should().BeGreaterThan(0);
        stop.Longitude.Should().BeLessThan(0);
        stop.GtfsFileId.Should().Be(99);
    }
}
