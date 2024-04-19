using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product pickup capability response
    /// </summary>
    public class PickupCapabilityResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="OriginServiceCodeArea"/> property
        /// </summary>
        private string? mOriginServiceCodeArea;

        /// <summary>
        /// The member of the <see cref="OriginFacilityAreaCode"/> property
        /// </summary>
        private string? mOriginFacilityAreaCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// This indicator has values of Y or N, and tells the consumer if the service in the response has a pickup date on the same day as the requested shipment date (per the request).
        /// </summary>
        [JsonProperty("nextBusinessDay")]
        public bool ShouldDeliverNextBusinessDay { get; set; }

        /// <summary>
        /// This is the cutoff time for the service<BR> offered in the response. This represents the latest time (local to origin) which the shipment can be tendered to the courier for that service on that day.
        /// </summary>
        /// <example>2019-09-18T15:00:00</example>
        [JsonProperty("localCutoffDateAndTime")]
        public DateTime LocalCutoffDateAndTime { get; set; }

        /// <summary>
        /// Pickup cut off time in GMT
        /// </summary>
        /// <example>16:00:00</example>
        [JsonProperty("GMTCutoffTime")]
        public TimeOnly GMTCutoffTime { get; set; }

        /// <summary>
        /// The DHL earliest time possible for pickup
        /// </summary>
        /// <example>09:30:00</example>
        [JsonProperty("pickupEarliest")]
        public TimeOnly PickupEarliest { get; set; }

        /// <summary>
        /// The DHL latest time possible for pickup
        /// </summary>
        /// <example>16:00:00</example>
        [JsonProperty("pickupLatest")]
        public TimeOnly PickupLatest { get; set; }

        /// <summary>
        /// The DHL Service Area Code for the origin of the Shipment
        /// </summary>
        /// <example>ELA</example>
        [JsonProperty("originServiceCodeArea")]
        public string OriginServiceCodeArea
        {
            get => mOriginServiceCodeArea ?? string.Empty;
            set => mOriginServiceCodeArea = value;
        }

        /// <summary>
        /// The DHL facility code for the origin
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
        [JsonConverter(typeof(DHLDayOfWeekTypeToStringJsonConverter))]
        public DHLDayOfWeek PickupDayOfWeek { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PickupCapabilityResponseModel() : base()
        {

        }

        #endregion
    }
}