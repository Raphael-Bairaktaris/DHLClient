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
        private ServicePointLocationResponseModel? mLocations;

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="Place"/> property
        /// </summary>
        private ServicePointLocationByPlaceResponseModel? mPlace;

        /// <summary>
        /// The member of the <see cref="ServiceTypes"/> property
        /// </summary>
        private IEnumerable<ServiceType>? mServiceTypes;

        /// <summary>
        /// The member of the <see cref="AverageCapacityDayOfWeek"/> property
        /// </summary>
        private IEnumerable<ServicePointLocationAverageCapacityDayOfWeekResponseModel>? mAverageCapacityDayOfWeek;

        /// <summary>
        /// The member of the <see cref="OpeningHours"/> property
        /// </summary>
        private IEnumerable<ServicePointLocationOpeningHoursResponseModel>? mOpeningHours;

        /// <summary>
        /// The member of the <see cref="ClosurePeriods"/> property
        /// </summary>
        private IEnumerable<ServicePointLocationClosurePeriodResponseModel>? mClosurePeriods;


        #endregion

        #region Public Properties

        /// <summary>
        /// The `self` link relation - globally unique identifier of this DHL Service Point location.
        /// </summary>
        /// <example>/locations/8003-4103535</example>
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        /// <summary>
        /// The locations
        /// </summary>
        [JsonProperty("locations")]
        public ServicePointLocationResponseModel Locations
        {
            get => mLocations ?? new ServicePointLocationResponseModel();
            set => mLocations = value;
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
        public double Distance { get; set; }

        /// <summary>
        /// The place
        /// </summary>
        [JsonProperty("place")]
        public ServicePointLocationByPlaceResponseModel Place
        {
            get => mPlace ??= new ServicePointLocationByPlaceResponseModel();
            set => mPlace = value;
        }

        /// <summary>
        /// The list of services available at the DHL Service Point location.
        /// </summary>
        [JsonProperty("serviceTypes")]
        [JsonConverter(typeof(ServiceTypeEnumEnumerableToStringJsonConverter))]
        public IEnumerable<ServiceType> ServiceTypes
        {
            get => mServiceTypes ?? Enumerable.Empty<ServiceType>();
            set => mServiceTypes = value;
        }

        /// <summary>
        /// Indicates the average capacity of the parcel locker on the listed day. If this information is not available,
        /// only an aggregated average capacity indication based on the last weeks will be provided as availableCapacity.
        /// </summary>
        [JsonProperty("averageCapacityDayOfWeek")]
        public IEnumerable<ServicePointLocationAverageCapacityDayOfWeekResponseModel> AverageCapacityDayOfWeek
        {
            get => mAverageCapacityDayOfWeek ??= Enumerable.Empty<ServicePointLocationAverageCapacityDayOfWeekResponseModel>();
            set => mAverageCapacityDayOfWeek = value;
        }

        /// <summary>
        /// Information on the average availability of locker capacity (only available in Germany).
        /// </summary>
        [JsonProperty("availableCapacity")]
        [JsonConverter(typeof(CapacityTypeToStringJsonConverter))]
        public CapacityType AvailableCapacity { get; set; }

        /// <summary>
        /// List of the opening hours of the DHL Service Point location.
        /// </summary>
        /// <remarks>http://supermodel.io/schemaorg/OpeningHoursSpecification</remarks>
        [JsonProperty("openingHours")]
        public IEnumerable<ServicePointLocationOpeningHoursResponseModel> OpeningHours
        {
            get => mOpeningHours ?? Enumerable.Empty<ServicePointLocationOpeningHoursResponseModel>();
            set => mOpeningHours = value;
        }

        /// <summary>
        /// Periods where the DHL Service Point location is closed in the addition to opening hours.
        /// </summary>
        [JsonProperty("closurePeriods")]
        public IEnumerable<ServicePointLocationClosurePeriodResponseModel> ClosurePeriods
        {
            get => mClosurePeriods ?? Enumerable.Empty<ServicePointLocationClosurePeriodResponseModel>();
            set => mClosurePeriods = value;
        }

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