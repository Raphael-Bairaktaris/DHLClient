using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a DHL Service Point locations collection response
    /// </summary>
    public class ServicePointLocationsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Locations"/> property
        /// </summary>
        private IEnumerable<ServicePointLocationResponseModel>? mLocations;

        /// <summary>
        /// The member of the <see cref="URL"/> property
        /// </summary>
        private string? mURL;

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The locations
        /// </summary>
        [JsonProperty("locations")]
        public IEnumerable<ServicePointLocationResponseModel> Locations
        {
            get => mLocations ?? Enumerable.Empty<ServicePointLocationResponseModel>();
            set => mLocations = value;
        }

        /// <summary>
        /// The `self` link relation - globally unique identifier of this DHL Service Point location.
        /// </summary>
        [JsonProperty("url")]
        public string URL
        {
            get => mURL ?? string.Empty;
            set => mURL = value;
        }

        /// <summary>
        /// Name of the DHL Service Point location.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// Distance in meters (m) from the requested geographical coordinates.
        /// </summary>
        [JsonProperty("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// An object of objects
        /// </summary>
        [JsonProperty("place")]
        public ServicePointLocationByPlaceResponseModel Places { get; set; }

        /// <summary>
        /// The list of services available at the DHL Service Point location.
        /// </summary>
        [JsonProperty("serviceTypes")]
        public ServiceType ServiceTypes { get; set; }

        /// <summary>
        /// Indicates the average capacity of the parcel locker on the listed day. If this information is not available,
        /// only an aggregated average capacity indication based on the last weeks will be provided as availableCapacity.
        /// </summary>
        [JsonProperty("averageCapacityDayOfWeek")]
        public ServicePointLocationAverageCapacityDayOfWeekResponseModel AverageCapacityDayOfWeek { get; set; }

        /// <summary>
        /// List of the opening hours of the DHL Service Point location.
        /// </summary>
        /// <remarks>http://supermodel.io/schemaorg/OpeningHoursSpecification</remarks>
        [JsonProperty("openingHours")]
        public ServicePointLocationOpeningHoursResponseModel OpeningHours { get; set; }

        /// <summary>
        /// Periods where the DHL Service Point location is closed in the addition to opening hours.
        /// </summary>
        [JsonProperty("closurePeriods")]
        public ServicePointLocationClosurePeriodResponseModel ClosurePeriods { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationsResponseModel() : base()
        {

        }

        #endregion
    }
}