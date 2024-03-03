namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StopWrapper"/> class,
    ///     which is used to wrap calls to the Proto Stop API endpoints.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    /// <inheritdoc cref="IStopWrapper"/>
    public class StopWrapper : HttpBase, IStopWrapper
    {
        private const string _baseAddress = "https://www.buseireann.ie/inc/proto/";

        public List<BusStop> BusStops { get; set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="StopWrapper"/> class,
        ///     which is used to wrap calls to the Proto Stop API endpoints.
        /// </summary>
        public StopWrapper()
            : base(HttpVersion.Version11, "")
        {
            this.HttpClient.BaseAddress = new Uri(_baseAddress);
            this.BusStops = new List<BusStop>(0);
        }

        /// <summary>
        ///     Gets and stores the list of bus stops for a given geo location.
        /// </summary>
        /// <param name="latitudeNorth">Latitude North</param>
        /// <param name="latitudeSouth">Latitude South</param>
        /// <param name="longitudeEast">Longitude East</param>
        /// <param name="longitudeWest">Longitude West</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        public async Task GetStopsForGeoLocationAsync(string latitudeNorth, string latitudeSouth, string longitudeEast, string longitudeWest)
        {
            var instanceTime = Math.Round((DateTime.UtcNow - DateTime.UnixEpoch).TotalMilliseconds, 0);
            var url = $"stopPointTdi.php?latitude_north={latitudeNorth}&latitude_south={latitudeSouth}& longitude_east={longitudeEast}&longitude_west={longitudeWest}&_={instanceTime}";
            var result = await this.HttpClient.GetAsync<StopPointTdiResponse>(url);
            if (result != null)
            {
                var stopPointTdi = result.StopPointTdi;
                for(int x = 0; x <= 7; x++)
                {
                    var nameOfProperty = $"BusStop{x}";
                    var propertyInfo = stopPointTdi.GetType().GetProperty(nameOfProperty);
                    var value = propertyInfo!.GetValue(stopPointTdi, null);
                    if (value != null) 
                    {
                        this.BusStops.Add((BusStop)value);
                    }
                }
            }
        }

        /// <summary>
        ///     The Passages for an already retrieved list of stops.
        ///     <para><see cref="GetStopsForGeoLocationAsync"/> MUST be called, first.</para>
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TaskToAsyncResult}"/> of <see cref="List{T}"/> of <see cref="CorrelatedPassages"/>.</returns>
        public async Task<List<CorrelatedPassages>> GetPassagesForStopsAsync()
        {
            if (this.BusStops.Count == 0)
            {
                throw new InvalidOperationException("You must call `GetStopsForGeoLocationAsync` to populate the Bus Stops, first.");
            }
            var listOfCorrelatedPassages = new List<CorrelatedPassages>(0);
            var instanceTime = Math.Round((DateTime.UtcNow - DateTime.UnixEpoch).TotalMilliseconds, 0);
            foreach (var busStop in this.BusStops) 
            {
                var url = $"stopPassageTdi.php?stop_point={busStop.Duid}&_={instanceTime}";
                var result = await this.HttpClient.GetAsync<StopPassageTdiResponse>(url);
                if (result != null) 
                {
                    var passages = new List<Passage>(0);
                    var stopPassageTdi = result.StopPassageTdi;
                    for (int x = 0; x <= 50; x++)
                    {
                        var nameOfProperty = $"Passage{x}";
                        var propertyInfo = stopPassageTdi.GetType().GetProperty(nameOfProperty);
                        var value = propertyInfo!.GetValue(stopPassageTdi, null);
                        if (value != null)
                        {
                            passages.Add((Passage)value);
                        }
                    }

                    listOfCorrelatedPassages.Add(new CorrelatedPassages
                    {
                        BusStop = busStop,
                        Passages = passages
                    });
                }
            }
            listOfCorrelatedPassages.ForEach(x =>
            {

                var oderedPassages = x.Passages.OrderByChained([x => x.ArrivalData.ScheduledPassageTimeUtc, y => y.DepartureData.ScheduledPassageTimeUtc]);
                x.Passages = [.. oderedPassages];
            });

            return listOfCorrelatedPassages.OrderBy(z => z.BusStop.LongName).ToList();
        }
    }
}