# Felsökning.Ireland

The `Felsökning.Ireland` NuGet package provides a collection of classes and methods tailored for Irish-specific data and services. Below is a detailed overview of the available methods and their return types.

---

## **Namespaces and Classes**

### **`Felsökning.Ireland.RTE`**
#### **Class: `Summary`**
Represents summaries with varying levels of detail.

- **Properties**:
  - `Short` *(string)*: A short summary.
  - `Medium` *(string)*: A medium-length summary.
  - `Long` *(string)*: A detailed summary.

---

### **`Felsökning.Ireland.CADCO`**
#### **Methods**
- **`GetArrivals(string airportCode)`**
  - **Description**: Retrieves a list of arrivals for the specified airport.
  - **Parameters**:
    - `airportCode` *(string)*: The IATA code of the airport (e.g., "EIKN").
  - **Returns**: `IEnumerable<Flight>` - A collection of flight details.

- **`GetDepartures(string airportCode)`**
  - **Description**: Retrieves a list of departures for the specified airport.
  - **Parameters**:
    - `airportCode` *(string)*: The IATA code of the airport (e.g., "EIKN").
  - **Returns**: `IEnumerable<Flight>` - A collection of flight details.

---

### **`Felsökning.Ireland.BusÉireann`**
#### **Methods**
- **`GetBusTimetable(string routeNumber)`**
  - **Description**: Fetches the timetable for a specific bus route.
  - **Parameters**:
    - `routeNumber` *(string)*: The bus route number (e.g., "X20").
  - **Returns**: `Timetable` - A structured timetable object.

---

### **`Felsökning.Ireland.IarnródÉireann`**
#### **Methods**
- **`GetTrainSchedule(string stationCode)`**
  - **Description**: Retrieves the train schedule for a specific station.
  - **Parameters**:
    - `stationCode` *(string)*: The station code (e.g., "DUB").
  - **Returns**: `IEnumerable<TrainSchedule>` - A collection of train schedules.

---

### **`Felsökning.Ireland.MetÉireann`**
#### **Methods**
- **`GetWeatherForecast(string location)`**
  - **Description**: Provides the weather forecast for a given location.
  - **Parameters**:
    - `location` *(string)*: The name of the location (e.g., "Dublin").
  - **Returns**: `WeatherForecast` - A detailed weather forecast object.

---

## **Installation**

Install the package via NuGet:

```sh
dotnet add package [Felsökning.Ireland](http://_vscodecontentref_/1)