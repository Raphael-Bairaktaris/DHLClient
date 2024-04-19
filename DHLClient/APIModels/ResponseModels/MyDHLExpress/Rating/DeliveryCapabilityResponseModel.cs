using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product delivery capability response
    /// </summary>
    public class DeliveryCapabilityResponseModel
    {
        #region Private Members

        /// <summary>
        /// the member of  the <see cref="DestinationServiceAreaCode"/> property
        /// </summary>
        private string? mDestinationServiceAreaCode;

        /// <summary>
        /// the member of  the <see cref="DestinationServiceAreaCode"/> property
        /// </summary>
        private string? mDestinationFacilityAreaCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Delivery Date capabilities considering customs clearance days
        /// </summary>
        [JsonProperty("deliveryTypeCode")]
        [JsonConverter(typeof(DeliveryTypeToStringJsonConverter))]
        public DeliveryType DeliveryTypeCode { get; set; }

        /// <summary>
        /// This is the estimated date/time the shipment will be delivered by for the rated shipment and product listed
        /// </summary>
        /// <example>2019-09-20T12:00:00</example>
        [JsonProperty("estimatedDeliveryDateAndtime")]
        public DateTime EstimatedDeliveryDateAndtime { get; set; }

        /// <summary>
        /// The DHL Service Area Code for the destination of the Shipment
        /// </summary>
        [JsonProperty("destinationServiceAreaCode")]
        public string DestinationServiceAreaCode
        {
            get => mDestinationServiceAreaCode ?? string.Empty;
            set => mDestinationServiceAreaCode = value;
        }

        /// <summary>
        /// The DHL Facility Code for the Destination
        /// </summary>
        [JsonProperty("destinationFacilityAreaCode")]
        public string DestinationFacilityAreaCode
        {
            get => mDestinationFacilityAreaCode ?? string.Empty;
            set => mDestinationFacilityAreaCode = value;
        }

        /// <summary>
        /// This is additional transit delays (in days) for shipment delivered to the<BR> mentioned city or postal area following arrival at the service area.
        /// </summary>
        [JsonProperty("deliveryAdditionalDays")]
        public double DeliveryAdditionalDays { get; set; }

        /// <summary>
        /// Delivery day of the week number
        /// </summary>
        [JsonProperty("deliveryDayOfWeek")]
        [JsonConverter(typeof(DHLDayOfWeekTypeToStringJsonConverter))]
        public DHLDayOfWeek DeliveryDayOfWeek { get; set; }

        /// <summary>
        /// The number of transit days
        /// </summary>
        [JsonProperty("totalTransitDays")]
        public int TotalTransitDays { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryCapabilityResponseModel() : base()
        {

        }

        #endregion
    }
}