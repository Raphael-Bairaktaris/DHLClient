using Newtonsoft.Json;

namespace DHLClient.LocationUnified
{
    /// <summary>
    /// The base for all multiple service point locations
    /// </summary>
    public class BaseMultipleServicePointLocationsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Locations"/> property
        /// </summary>
        private IEnumerable<LocationResponseModel> mLocations;

        #endregion

        #region Public Properties

        /// <summary>
        /// The `self` link relation - globally unique identifier of this DHL Service Point location.
        /// </summary>
        /// <example>/locations/8003-4103535</example>
        [JsonProperty("url")]
        public Uri? URL { get; set; }

        /// <summary>
        /// DHL Service Point location collection
        /// </summary>
        [JsonProperty("locations")]
        public IEnumerable<LocationResponseModel> Locations
        {
            get => mLocations ?? Enumerable.Empty<LocationResponseModel>();
            set => mLocations = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseMultipleServicePointLocationsResponseModel() : base()
        {

        }

        #endregion
    }
}
