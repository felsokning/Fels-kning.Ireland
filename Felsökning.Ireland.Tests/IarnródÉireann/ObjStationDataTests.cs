//-----------------------------------------------------------------------
// <copyright file="ObjStationDataTests.cs" company="Felskningen">
//     Copyright (c) Felskningen. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Felsökning.Ireland.Tests.IarnródÉireann;

[TestClass]
[ExcludeFromCodeCoverage]
public class ObjStationDataTests
{
    [TestMethod]
    public void ObjStationData_DirectConstruction_AllStringPropertiesSettable()
    {
        var data = new ObjStationData
        {
            Traincode = "R431",
            Stationfullname = "Dublin Connolly",
            Stationcode = "DCC",
            Traindate = "2025-03-15",
            Origin = "Cork Kent",
            Destination = "Sligo",
            Origintime = "06:30:00",
            Destinationtime = "11:45:00",
            Direction = "Northbound",
            Traintype = "R",
            Locationtype = "Arrival"
        };

        data.Traincode.Should().Be("R431");
        data.Stationfullname.Should().Be("Dublin Connolly");
        data.Stationcode.Should().Be("DCC");
        data.Origin.Should().Be("Cork Kent");
        data.Destination.Should().Be("Sligo");
        data.Direction.Should().Be("Northbound");
        data.Traintype.Should().Be("R");
        data.Locationtype.Should().Be("Arrival");
    }

    [TestMethod]
    public void ObjStationData_DirectConstruction_TimeFieldsSettable()
    {
        var servertime = new DateTime(2025, 3, 15, 8, 0, 0);
        var querytime = new DateTime(2025, 3, 15, 7, 59, 0);

        var data = new ObjStationData
        {
            Servertime = servertime,
            Querytime = querytime,
            Exparrival = "11:40:00",
            Expdepart = "11:42:00",
            Scharrival = "11:38:00",
            Schdepart = "11:40:00"
        };

        data.Servertime.Should().Be(servertime);
        data.Querytime.Should().Be(querytime);
        data.Exparrival.Should().Be("11:40:00");
        data.Expdepart.Should().Be("11:42:00");
        data.Scharrival.Should().Be("11:38:00");
        data.Schdepart.Should().Be("11:40:00");
    }

    [TestMethod]
    public void ObjStationData_DirectConstruction_NumericFieldsSettable()
    {
        var data = new ObjStationData
        {
            Duein = 5,
            Late = 2
        };

        data.Duein.Should().Be((byte)5);
        data.Late.Should().Be((sbyte)2);
    }

    [TestMethod]
    public void ObjStationData_StatusSetter_WithNull_DoesNotSetBranch()
    {
        var data = new ObjStationData();
        data.Status = null;
        // Setter: if (value != null && IsWhiteSpace(value)) => false, field stays null
        data.Status.Should().BeNull();
    }

    [TestMethod]
    public void ObjStationData_StatusSetter_WithEmptyString_SetsTheField()
    {
        var data = new ObjStationData();
        data.Status = "";
        // Setter: (value != null && IsWhiteSpace("")) => true, field set to ""
        // This tests the TRUE branch of the if-statement in the setter
        data.Status.Should().Be("");
    }

    [TestMethod]
    public void ObjStationData_StatusSetter_WithWhitespaceOnly_SetsTheField()
    {
        var data = new ObjStationData();
        data.Status = "   ";
        // Setter: (value != null && IsWhiteSpace("   ")) => true, field set to "   "
        data.Status.Should().Be("   ");
    }

    [TestMethod]
    public void ObjStationData_StatusSetter_WithValidNonWhitespaceString_DoesNotSetBranch()
    {
        var data = new ObjStationData();
        // First set a value so the field has something
        data.Status = "";
        // Then try to set "Due" — setter condition (value != null && IsWhiteSpace("Due")) is FALSE
        // so statusField remains unchanged from previous set
        data.Status = "Due";
        data.Status.Should().Be("");
    }

    [TestMethod]
    public void ObjStationData_StatusSetter_WithMeantimeValue_FalseBranch()
    {
        var data = new ObjStationData();
        data.Status = "\t ";
        // Tests the TRUE branch — sets to "\t "
        data.Status.Should().Be("\t ");
    }

    [TestMethod]
    public void ObjStationData_LastLocationSetter_WithNull_DoesNotSetBranch()
    {
        var data = new ObjStationData();
        data.Lastlocation = null;
        data.Lastlocation.Should().BeNull();
    }

    [TestMethod]
    public void ObjStationData_LastLocationSetter_WithEmptyString_SetsTheField()
    {
        var data = new ObjStationData();
        data.Lastlocation = "";
        // TRUE branch of setter: (value != null && IsWhiteSpace("")) => true
        data.Lastlocation.Should().Be("");
    }

    [TestMethod]
    public void ObjStationData_LastLocationSetter_WithWhitespaceOnly_SetsTheField()
    {
        var data = new ObjStationData();
        data.Lastlocation = "\t \n";
        // TRUE branch of setter: (value != null && IsWhiteSpace("\t \n")) => true
        data.Lastlocation.Should().Be("\t \n");
    }

    [TestMethod]
    public void ObjStationData_LastLocationSetter_WithValidText_DoesNotSetBranch()
    {
        var data = new ObjStationData();
        data.Lastlocation = "";
        data.Lastlocation = "Connemara";
        // FALSE branch: IsWhiteSpace("Connemara") => false, field unchanged
        data.Lastlocation.Should().Be("");
    }
}
