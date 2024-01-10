using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product delivery capability response
    /// </summary>
    public class ProductDeliveryCapabilitiesResponseModel
    {
        #region Private Members 

        /// <summary>
        /// The member of the <see cref="DestinationServiceAreaCode"/> property
        /// </summary>
        private string? mDestinationServiceAreaCode;

        /// <summary>
        /// The member of the <see cref="DestinationFacilityAreaCode"/> property
        /// </summary>
        private string? mDestinationFacilityAreaCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Delivery Date capabilities considering customs clearance days.
        /// </summary>
        [JsonProperty("deliveryTypeCode")]
        public DeliveryType DeliveryTypeCode { get; set; }

        /// <summary>
        /// This is the estimated date/time the shipment will be delivered by for the rated shipment and product listed
        /// </summary>
        [JsonProperty("estimatedDeliveryDateAndTime")]
        public DateTimeOffset EstimatedDelivery { get; set; }

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
        /// This is additional transit delays (in days) for shipment delivered to the mentioned city or postal area following arrival at the service area.
        /// </summary>
        [JsonProperty("deliveryAdditionalDays")]
        public double DeliveryAdditionalDays { get; set; }

        /// <summary>
        /// Destination day of the week number
        /// </summary>
        public DayOfWeek DeliveryDayOfWeek { get; set; }

        /// <summary>
        /// The number of transit days
        /// </summary>
        public double TotalTransitDays { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductDeliveryCapabilitiesResponseModel() : base()
        {

        }

        #endregion
    }
}