using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail response
    /// </summary>
    public class ServicePointDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// the member of the <see cref="FacilityId"/> property
        /// </summary>
        private string? mFacilityId;

        /// <summary>
        /// The member of the <see cref="FacilityTypeCode"/> property
        /// </summary>
        private string? mFacilityTypeCode;

        /// <summary>
        /// The member of the <see cref="ServiceAreaCode"/> property
        /// </summary>
        private string? mServiceAreaCode;

        /// <summary>
        /// The member of the <see cref="ServicePointName"/> property
        /// </summary>
        private string? mServicePointName;

        /// <summary>
        /// The member of the <see cref="LocalName"/> property
        /// </summary>
        private string? mLocalName;

        private ServicePointDetailAddressResponseModel? mAddress;

        /// <summary>
        /// The member of the <see cref="GeographicLocation"/> property
        /// </summary>
        private ServicePointDetailGeograpgicalLocationResponseModel? mGeographicLocation;

        #endregion

        #region Public Properties

        /// <summary>
        /// The facility ID from GREF database
        /// </summary>
        [JsonProperty("id")]
        public double Id { get; set; }

        /// <summary>
        /// Service Point ID is a unique key with 6 characters, consisting of Service Area for first 3 characters
        /// and the last 3 characters is the Facility code
        /// </summary>
        /// <example>ID = BRU001</example>
        [JsonProperty("facilityId")]
        public string FacilityId
        {
            get => mFacilityId ?? string.Empty;
            set => mFacilityId = value;
        }

        /// <summary>
        /// The facility type code from GREF database
        /// </summary>
        [JsonProperty("facilityTypeCode")]
        public string FacilityTypeCode
        {
            get => mFacilityTypeCode ?? string.Empty;
            set => mFacilityTypeCode = value;
        }

        /// <summary>
        /// The service point’s Service Area Code
        /// </summary>
        [JsonProperty("serviceAreaCode")]
        public string ServiceAreaCode
        {
            get => mServiceAreaCode ?? string.Empty;
            set => mServiceAreaCode = value;
        }

        /// <summary>
        /// Name of the service point
        /// </summary>
        [JsonProperty("servicePointName")]
        public string ServicePointName
        {
            get => mServicePointName ?? string.Empty;
            set => mServicePointName = value;
        }

        /// <summary>
        /// Formatted name of the service point
        /// </summary>
        [JsonProperty("localName")]
        public string LocalName
        {
            get => mLocalName ?? string.Empty;
            set => mLocalName = value;
        }

        /// <summary>
        /// The type of the Service Point.
        /// </summary>
        [JsonProperty("servicePointType")]
        public ServicePoint ServicePointType { get; set; }

        /// <summary>
        /// Sub-entity holding the facility address
        /// </summary>
        [JsonProperty("address")]
        public ServicePointDetailAddressResponseModel Address 
        { 
            get => mAddress ??= new ServicePointDetailAddressResponseModel();
            set => mAddress = value;
        }

        /// <summary>
        /// The geographical coordinates of the facility’s location
        /// </summary>
        [JsonProperty("geoLocation")]
        public ServicePointDetailGeograpgicalLocationResponseModel GeographicLocation 
        { 
            get => mGeographicLocation ??= new ServicePointDetailGeograpgicalLocationResponseModel();
            set => mGeographicLocation = value;
        }

        /// <summary>
        /// The distance from the search address to this Service Point (beeline).
        /// </summary>
        [JsonProperty("distance")]
        public double Distance { get; set; }

        /// <summary>
        /// Time until which a shipment can be handed in at the Service Point, and is still shipped on the same day
        /// </summary>
        [JsonProperty("shippingCutOffTime")]
        public TimeOnly ShippingCutOffTime { get; set; }

        /// <summary>
        /// Array of openingHours entities, each consisting of week day, opening time and closing time.
        /// </summary>
        [JsonProperty("openingHours")]
        public IEnumerable<ServicePointDetailOpeningHoursResponseModel> OpeningHours { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailResponseModel() : base()
        {

        }

        #endregion
    }
}