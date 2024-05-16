using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents pickup details
    /// </summary>
    public class PickupDetailResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Pickup booking cutoff time
        /// </summary>
        /// <example>2021-10-04T16:30:00</example>
        [JsonProperty("localCutoffDateAndTime")]
        public DateTimeOffset LocalCutoffDateAndTime { get; set; }

        /// <summary>
        /// Pickup cutoff time in GMT
        /// </summary>
        /// <example>17:00:00</example>
        [JsonProperty("gmtCutoffTime")]
        public TimeOnly GMTCutoffTime { get; set; }

        /// <summary>
        /// Pickup booking cutoff time in GMT offset
        /// </summary>
        /// <example>PT30M</example>
        [JsonProperty("cutoffTimeOffset")]
        [JsonConverter(typeof(TimeSpanToISO8601StringJsonConverter))]
        public TimeSpan CutoffTimeOffset { get; set; }

        /// <summary>
        /// The DHL earliest time possible for pickup
        /// </summary>
        /// <example>09:00:00</example>
        [JsonProperty("pickupEarliest")]
        public TimeOnly PickupEarliest { get; set; }

        /// <summary>
        /// The DHL latest time possible for pickup
        /// </summary>
        [JsonProperty("pickupLatest")]
        public TimeOnly PickupLatest { get; set; }

        /// <summary>
        /// The number of transit days
        /// </summary>
        /// <example>8</example>
        [JsonProperty("totalTransitDays")]
        public int TotalTransitDays { get; set; }

        /// <summary>
        /// This is additional transit delays (in days) for shipment picked up from the mentioned city or postal area to arrival at the service area
        /// </summary>
        /// <example>0</example>
        [JsonProperty("pickupAdditionalDays")]
        public int PickupAdditionalDays { get; set; }

        /// <summary>
        /// This is additional transit delays (in days) for shipment delivered to the mentioned city or postal area following arrival at the service area
        /// </summary>
        /// <example>0</example>
        [JsonProperty("deliveryAdditionalDays")]
        public int DeliveryAdditionalDays { get; set; }

        /// <summary>
        /// Pickup day of the week number
        /// </summary>
        /// <example>1</example>
        [JsonProperty("pickupDayOfWeek")]
        [JsonConverter(typeof(DHLDayOfWeekToIntJsonConverter))]
        public DHLDayOfWeek PickupDayOfWeek { get; set; }

        /// <summary>
        /// Destination day of the week number
        /// </summary>
        /// <example>2</example>
        [JsonProperty("deliveryDayOfWeek")]
        [JsonConverter(typeof(DHLDayOfWeekToIntJsonConverter))]
        public DHLDayOfWeek DeliveryDayOfWeek { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PickupDetailResponseModel() : base()
        {

        }

        #endregion
    }
}