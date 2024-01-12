using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product pick up capability
    /// </summary>
    public class ProductPickupCapabilitiesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="OriginServiceAreaCode"/> property
        /// </summary>
        private string? mOriginServiceAreaCode;

        /// <summary>
        /// The member of the <see cref="OriginFacilityAreaCode"/> property 
        /// </summary>
        private string? mOriginFacilityAreaCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// This indicator has values of Y or N, and tells the consumer if the service in the response]
        /// has a pickup date on the same day as the requested shipment date (per the request).
        /// </summary>
        [JsonProperty("nextBusinessDay")]
        public bool CanPickupNextBusinessDay { get; set; }

        /// <summary>
        /// This is the cutoff time for the service offered in the response. This represents the latest time 
        /// (local to origin) which the shipment can be tendered to the courier for that service on that day.
        /// </summary>
        [JsonProperty("localCutoffDateAndTime")]
        public DateTimeOffset? LocalCutoffDateAndTime { get; set; }

        /// <summary>
        /// Pickup cut off time in GMT
        /// </summary>
        [JsonProperty("GMTCutoffTime")]
        public TimeOnly? GMTCutoffTime { get; set; }

        /// <summary>
        /// The DHL earliest time possible for pickup
        /// </summary>
        [JsonProperty("pickupEarliest")]
        public TimeOnly? PickupEarliest { get; set; }

        /// <summary>
        /// The DHL latest time possible for pickup
        /// </summary>
        [JsonProperty("pickupLatest")]
        public TimeOnly? PickupLatest { get; set; }

        /// <summary>
        /// The DHL Service Area Code for the origin of the Shipment
        /// </summary>
        [JsonProperty("originServiceAreaCode")]
        public string OriginServiceAreaCode
        {
            get => mOriginFacilityAreaCode ?? string.Empty;
            set => mOriginFacilityAreaCode = value;
        }

        /// <summary>
        /// The DHL Facility Code for the Origin
        /// </summary>
        [JsonProperty("originFacilityAreaCode")]
        public string OriginFacilityAreaCode
        {
            get => mOriginFacilityAreaCode ?? string.Empty;
            set => mOriginFacilityAreaCode = value;
        }

        /// <summary>
        /// This is additional transit delays (in days) for shipment picked up from the mentioned city or postal area to arrival at the service area.
        /// </summary>
        [JsonProperty("pickupAdditionalDays")]
        public double PickupAdditionalDays { get; set; }

        /// <summary>
        /// Pickup day of the week number
        /// </summary>
        [JsonProperty("pickupDayOfWeek")]
        public DayOfWeek? PickupDayOfWeek { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductPickupCapabilitiesResponseModel() : base()
        {

        }

        #endregion
    }
}