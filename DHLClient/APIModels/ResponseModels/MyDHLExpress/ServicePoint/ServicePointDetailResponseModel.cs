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
        /// The member of the <see cref="Id"/> property
        /// </summary>
        private string? mId;

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

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private ServicePointDetailAddressResponseModel? mAddress;

        /// <summary>
        /// The member of the <see cref="GeographicLocation"/> property
        /// </summary>
        private ServicePointDetailGeograpgicalLocationResponseModel? mGeographicLocation;

        /// <summary>
        /// The member of the <see cref="Distance"/> property
        /// </summary>
        private string? mDistance;

        /// <summary>
        /// The member of the <see cref="OpeningHours"/> property
        /// </summary>
        private ServicePointDetailOpeningHoursResponseModel? mOpeningHours;

        /// <summary>
        /// The member of the <see cref="ServicePointCapabilities"/> property
        /// </summary>
        private ServicePointDetailCapabilitiesResponseModel? mServicePointCapabilities;

        /// <summary>
        /// The member of the <see cref="ContactDetails"/> property
        /// </summary>
        private ServicePointContactDetailResponseModel? mContactDetails;

        /// <summary>
        /// The member of the <see cref="Language"/> property
        /// </summary>
        private ServicePointDetailLanguageResponseModel? mLanguage;

        /// <summary>
        /// The member of the <see cref="ShipmentLimitations"/> property
        /// </summary>
        private ServicePointDetailShipmentLimitationResponseModel? mShipmentLimitations;

        /// <summary>
        /// The member of the <see cref="ShipmentLimitationsByPiece"/> property
        /// </summary>
        private ShipmentLimitaionByPieceResponseModel? mShipmentLimitationsByPiece;

        /// <summary>
        /// The member of the <see cref="ChargeCode"/> property
        /// </summary>
        private string? mChargeCode;

        /// <summary>
        /// The member of the <see cref="Partner"/> property
        /// </summary>
        private ServicePointDetailPartnerResponseModel? mPartner;

        /// <summary>
        /// The member of the <see cref="Promotion"/> property
        /// </summary>
        private ServicePointPromotionResponseModel? mPromotion;

        /// <summary>
        /// The member of the <see cref="CapacityStatus"/> property
        /// </summary>
        private ServicePointDetailCapacityStatusResponseModel? mCapacityStatus;

        /// <summary>
        /// The member of the <see cref="SvpStatus"/> property
        /// </summary>
        private string? mSvpStatus;

        /// <summary>
        /// The member of the <see cref="LocatedAt"/> property
        /// </summary>
        private string? mLocatedAt;

        /// <summary>
        /// The member of the <see cref="TimeZone"/> property
        /// </summary>
        private ServicePointDetailTimeZoneResponseModel? mTimeZone;

        #endregion

        #region Public Properties

        /// <summary>
        /// The facility ID from GREF database
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get => mId ?? string.Empty;
            set => mId = value;
        }

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
        [JsonConverter(typeof(ServicePointToStringJsonConverter))]
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
        public string Distance
        {
            get => mDistance ?? string.Empty;
            set => mDistance = value;
        }

        /// <summary>
        /// Time until which a shipment can be handed in at the Service Point, and is still shipped on the same day
        /// </summary>
        [JsonProperty("shippingCutOffTime")]
        public TimeOnly ShippingCutOffTime { get; set; }

        /// <summary>
        /// Array of openingHours entities, each consisting of week day, opening time and closing time.
        /// </summary>
        [JsonProperty("openingHours")]
        public ServicePointDetailOpeningHoursResponseModel OpeningHours
        {
            get => mOpeningHours ??= new ServicePointDetailOpeningHoursResponseModel();
            set => mOpeningHours = value;
        }

        /// <summary>
        /// An entity that lists all capabilities of a Service Point.
        /// </summary>
        [JsonProperty("servicePointCapabilities")]
        public ServicePointDetailCapabilitiesResponseModel ServicePointCapabilities
        {
            get => mServicePointCapabilities ??= new ServicePointDetailCapabilitiesResponseModel();
            set => mServicePointCapabilities = value;
        }

        /// <summary>
        /// Information about how the Service Point can be contacted
        /// </summary>
        [JsonProperty("contactDetails")]
        public ServicePointContactDetailResponseModel ContactDetails
        {
            get => mContactDetails ??= new ServicePointContactDetailResponseModel();
            set => mContactDetails = value;
        }

        /// <summary>
        /// Distance of SVP from searched location
        /// </summary>
        [JsonProperty("distanceValue")]
        public double DistanceValue { get; set; }

        /// <summary>
        /// Metric of distance
        /// </summary>
        [JsonProperty("distanceMetric")]
        public double DistanceMetric { get; set; }

        /// <summary>
        /// Information about language used for search
        /// </summary>
        [JsonProperty("language")]
        public ServicePointDetailLanguageResponseModel Language
        {
            get => mLanguage ??= new ServicePointDetailLanguageResponseModel();
            set => mLanguage = value;
        }

        /// <summary>
        /// Information about shipment piece / size
        /// </summary>
        [JsonProperty("shipmentLimitations")]
        public ServicePointDetailShipmentLimitationResponseModel ShipmentLimitations
        {
            get => mShipmentLimitations ??= new ServicePointDetailShipmentLimitationResponseModel();
            set => mShipmentLimitations = value;
        }

        /// <summary>
        /// Shipment Piece Limitations in this Service Point.
        /// </summary>
        [JsonProperty("shipmentLimitationsByPiece")]
        public ShipmentLimitaionByPieceResponseModel ShipmentLimitationsByPiece
        {
            get => mShipmentLimitationsByPiece ??= new ShipmentLimitaionByPieceResponseModel();
            set => mShipmentLimitationsByPiece = value;
        }

        /// <summary>
        /// Charge code
        /// </summary>
        /// <example>XX</example>
        [JsonProperty("chargeCode")]
        public string ChargeCode
        {
            get => mChargeCode = string.Empty;
            set => mChargeCode = value;
        }

        /// <summary>
        /// Partner information (when SVP type is PRT)
        /// </summary>
        [JsonProperty("partner")]
        public ServicePointDetailPartnerResponseModel Partner
        {
            get => mPartner ??= new ServicePointDetailPartnerResponseModel();
            set => mPartner = value;
        }

        /// <summary>
        /// Promotion on a SVP level
        /// </summary>
        [JsonProperty("promotion")]
        public ServicePointPromotionResponseModel Promotion
        {
            get => mPromotion ??= new ServicePointPromotionResponseModel();
            set => mPromotion = value;
        }

        /// <summary>
        /// Capacity information – only if additional call to SCMS was triggered
        /// </summary>
        [JsonProperty("capacityStatus")]
        public ServicePointDetailCapacityStatusResponseModel CapacityStatus
        {
            get => mCapacityStatus ??= new ServicePointDetailCapacityStatusResponseModel();
            set => mCapacityStatus = value;
        }

        /// <summary>
        /// Status of the service point (active or inactive)
        /// </summary>
        [JsonProperty("svpStatus")]
        public string SvpStatus
        {
            get => mSvpStatus ??= string.Empty;
            set => mSvpStatus = value;
        }

        /// <summary>
        /// Value of day when the work week starts. It starts from 0 to 6(Sunday to Saturday)
        /// </summary>
        [JsonProperty("workWeekStart")]
        [JsonConverter(typeof(DHLDayOfWeekTypeToStringJsonConverter))]
        public DHLDayOfWeek WorkWeekStart { get; set; }

        /// <summary>
        /// The service point location
        /// </summary>
        [JsonProperty("locatedAt")]
        public string LocatedAt
        {
            get => mLocatedAt ??= string.Empty;
            set => mLocatedAt = value;
        }

        /// <summary>
        /// The service point time zone
        /// </summary>
        [JsonProperty("timeZone")]
        public ServicePointDetailTimeZoneResponseModel TimeZone
        {
            get => mTimeZone ??= new ServicePointDetailTimeZoneResponseModel();
            set => mTimeZone = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Id: {Id}, Facility Id: {FacilityId}, Service Point Name: {ServicePointName}, ";

        #endregion
    }
}