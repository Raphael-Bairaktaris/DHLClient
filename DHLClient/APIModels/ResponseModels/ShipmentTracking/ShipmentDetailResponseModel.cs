using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment tracking detail response
    /// </summary>
    public class ShipmentDetailResponseModel
    {
        #region MyRegion

        /// <summary>
        /// The member of the <see cref="Id"/> property
        /// </summary>
        private string? mId;

        /// <summary>
        /// The member of the <see cref="Origin"/> property
        /// </summary>
        private ShipmentDetailLocationResponseModel? mOrigin;

        /// <summary>
        /// The member of the <see cref="Destination"/> property
        /// </summary>
        private ShipmentDetailLocationResponseModel? mDestination;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private ShipmentStatusResponseModel? mStatus;

        /// <summary>
        /// The member of the <see cref="EstimatedDeliveryTimeFrameResponseModel"/> property
        /// </summary>
        private ShipmentDetailEstimatedDeliveryTimeFrameResponseModel? mEstimatedDeliveryTimeFrame;

        /// <summary>
        /// The member of the <see cref="EstimatedTimeOfDeliveryRemark"/> property
        /// </summary>
        private string? mEstimatedTimeOfDeliveryRemark;

        /// <summary>
        /// The member of the <see cref="Details"/> property
        /// </summary>
        private ShipmentDetailsResponseModel? mDetails;

        /// <summary>
        /// The member of the <see cref="Events"/> property
        /// </summary>
        private IEnumerable<ShipmentEventsResponseModel>? mEvents;

        /// <summary>
        /// The member of the <see cref="PossibleAdditionalShipmentsURL"/> property
        /// </summary>
        private IEnumerable<string>? mPossibleAdditionalShipmentsURL;

        #endregion

        #region Public Properties

        /// <summary>
        /// The location Id
        /// </summary>
        /// <example>GMDBD8E9CCE94842E495B71</example>
        [JsonProperty("id")]
        public string Id
        {
            get => mId ?? string.Empty;
            set => mId = value;
        }

        /// <summary>
        /// The shipment service type
        /// </summary>
        [JsonProperty("service")]
        [JsonConverter(typeof(ShipmentServiceTypeToStringJsonConverter))]
        public ShipmentServiceType Service { get; set; }

        /// <summary>
        /// The shipment origin
        /// </summary>
        [JsonProperty("origin")]
        public ShipmentDetailLocationResponseModel Origin
        {
            get => mOrigin ??= new ShipmentDetailLocationResponseModel();
            set => mOrigin = value;
        }

        /// <summary>
        /// The shipment destination
        /// </summary>
        [JsonProperty("destination")]
        public ShipmentDetailLocationResponseModel Destination
        {
            get => mDestination ??= new ShipmentDetailLocationResponseModel();
            set => mDestination = value;
        }

        /// <summary>
        /// The shipment status
        /// </summary>
        [JsonProperty("status")]
        public ShipmentStatusResponseModel Status
        {
            get => mStatus ??= new ShipmentStatusResponseModel();
            set => mStatus = value;
        }

        /// <summary>
        /// Shipment pickup date
        /// </summary>
        [JsonProperty("pickupDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly PickupDate { get; set; }

        /// <summary>
        /// The estimated time of delivery
        /// </summary>
        [JsonProperty("estimatedTimeOfDelivery")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimestampJsonConverter))]
        public DateTimeOffset? EstimatedTimeOfDelivery { get; set; }

        /// <summary>
        /// A term when shipment is expected to arrive
        /// </summary>
        [JsonProperty("estimatedDeliveryTimeFrame")]
        public ShipmentDetailEstimatedDeliveryTimeFrameResponseModel EstimatedDeliveryTimeFrameResponseModel
        {
            get => mEstimatedDeliveryTimeFrame ??= new ShipmentDetailEstimatedDeliveryTimeFrameResponseModel();
            set => mEstimatedDeliveryTimeFrame = value;
        }

        /// <summary>
        /// Human-readable description of the estimated delivery time
        /// </summary>
        [JsonProperty("estimatedTimeOfDeliveryRemark")]
        public string EstimatedTimeOfDeliveryRemark
        {
            get => mEstimatedTimeOfDeliveryRemark ?? string.Empty;
            set => mEstimatedTimeOfDeliveryRemark = value;
        }

        /// <summary>
        /// Custom link to BU tracking service
        /// </summary>
        /// <remarks> http://www.dhl.de/de/privatkunden.html?piececode=7777777770 </remarks>
        [JsonProperty("serviceUrl")]
        public Uri? ServiceURL { get; set; }

        /// <summary>
        /// Custom link to BU rerouting service, if available for the current status of the shipment
        /// </summary>
        /// <remarks> https://www.dhl.de/de/privatkunden.html?piececode=7777777770&verfuegen_selected_tab=FIRST </remarks>
        [JsonProperty("rerouteUrl")]
        public Uri? RerouteURL { get; set; }

        /// <summary>
        /// Custom link to BU rerouting service, if available for the current status of the shipment
        /// </summary>
        [JsonProperty("returnFlag")]
        public bool ShouldReturnFlag { get; set; }

        /// <summary>
        /// The shipment details
        /// </summary>
        [JsonProperty("details")]
        public ShipmentDetailsResponseModel Details
        {
            get => mDetails ??= new ShipmentDetailsResponseModel();
            set => mDetails = value;
        }

        /// <summary>
        /// Historical list of events & timestamps
        /// </summary>
        [JsonProperty("events")]
        public IEnumerable<ShipmentEventsResponseModel> Events
        {
            get => mEvents ?? Enumerable.Empty<ShipmentEventsResponseModel>();
            set => mEvents = value;
        }

        /// <summary>
        /// TAn array of business services, where should be potentially shipment found
        /// </summary>
        [JsonProperty("possibleAdditionalShipmentsURL")]
        public IEnumerable<string> PossibleAdditionalShipmentsURL
        {
            get => mPossibleAdditionalShipmentsURL ?? Enumerable.Empty<string>();
            set => mPossibleAdditionalShipmentsURL = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Location Id: {Id}, Pickup Date: {PickupDate}, Estimated Time of Delivery: {EstimatedTimeOfDelivery}";

        #endregion
    }
}
