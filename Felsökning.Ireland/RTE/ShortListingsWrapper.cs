
namespace Felsökning.Ireland.RTE
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ShortListingsWrapper"/>,
    ///     which wraps calls to obtain the Short TV Listing for RTE1 or RTE2.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    public class ShortListingsWrapper : HttpBase
    {
        private const string baseAddress = "https://www.rte.ie/data-feed/pa/";

        private const string rte1json = "rte-1.json";

        private const string rte2json = "rte-2.json";

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShortListingsWrapper"/>,
        ///     which wraps calls to obtain the Short TV Listing for RTE1 or RTE2.
        /// </summary>
        public ShortListingsWrapper()
            : base(HttpVersion.Version11, "Felsökning.Ireland")
        {
            this.HttpClient.BaseAddress = new Uri(baseAddress);
        }

        /// <summary>
        ///     Gets the Short TV Listings for RTE1.
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="ShortListing"/>.</returns>
        public async Task<ShortListing> GetRte1ShortListingAsync()
        {
            return await this.HttpClient.GetAsync<ShortListing>(rte1json);
        }

        /// <summary>
        ///     Gets the Short TV Listings for RTE2.
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="ShortListing"/>.</returns>
        public async Task<ShortListing> GetRte2ShortListingAsync()
        {
            return await this.HttpClient.GetAsync<ShortListing>(rte2json);
        }
    }
}