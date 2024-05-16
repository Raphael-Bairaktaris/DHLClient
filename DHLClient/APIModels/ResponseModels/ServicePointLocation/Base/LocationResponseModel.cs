using Newtonsoft.Json;

namespace DHLClient.LocationUnified
{
    /// <summary>
    /// Represents a service point location
    /// </summary>
    public class LocationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Locations"/> property
        /// </summary>
        private IEnumerable<LocationsResponseModel>? mLocations;

        #endregion

        #region Public Properties

        /// <summary>
        /// DHL Service Point location collection
        /// </summary>
        [JsonProperty("locations")]
        public IEnumerable<LocationsResponseModel> Locations
        {
            get => mLocations ?? Enumerable.Empty<LocationsResponseModel>();
            set => mLocations = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationResponseModel() : base()
        {

        }

        #endregion

    }
}
