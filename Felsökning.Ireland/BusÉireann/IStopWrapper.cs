namespace Felsökning.Ireland.BusÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IStopWrapper"/> interface.
    /// </summary>
    public interface IStopWrapper
    {
        /// <summary>
        ///     Gets and stores the list of bus stops for a given geo location.
        /// </summary>
        /// <param name="latitudeNorth">Latitude North</param>
        /// <param name="latitudeSouth">Latitude South</param>
        /// <param name="longitudeEast">Longitude East</param>
        /// <param name="longitudeWest">Longitude West</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        Task GetStopsForGeoLocationAsync(string latitudeNorth, string latitudeSouth, string longitudeEast, string longitudeWest);

        /// <summary>
        ///     The Passages for an already retrieved list of stops.
        ///     <para><see cref="GetStopsForGeoLocationAsync"/> MUST be called, first.</para>
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TaskToAsyncResult}"/> of <see cref="List{T}"/> of <see cref="CorrelatedPassages"/>.</returns>
        Task<List<CorrelatedPassages>> GetPassagesForStopsAsync();
    }
}