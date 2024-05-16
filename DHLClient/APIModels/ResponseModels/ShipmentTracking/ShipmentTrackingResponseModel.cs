using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a shipment tracking response
    /// </summary>
    public class ShipmentTrackingResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Shipments"/> property
        /// </summary>
        private IEnumerable<ShipmentTrackingDetailResponseModel>? mShipments;

        #endregion

        #region Public Property

        /// <summary>
        /// The URL
        /// </summary>
        [JsonProperty("url")]
        public Uri? URL { get; set; }

        /// <summary>
        /// The previous URL
        /// </summary>
        [JsonProperty("prevUrl")]
        public Uri? PreviousURL { get; set; }

        /// <summary>
        /// The next URL
        /// </summary>
        [JsonProperty("nextUrl")]
        public Uri? NextURL { get; set; }

        /// <summary>
        /// The first URL
        /// </summary>
        [JsonProperty("firstUrl")]
        public Uri? FirstURL { get; set; }

        /// <summary>
        /// The last URL
        /// </summary>
        [JsonProperty("lastUrl")]
        public Uri? LastURL { get; set; }

        /// <summary>
        /// The shipments details
        /// </summary>
        [JsonProperty("shipments")]
        public IEnumerable<ShipmentTrackingDetailResponseModel> Shipments
        {
            get => mShipments ?? Enumerable.Empty<ShipmentTrackingDetailResponseModel>();
            set => mShipments = value;
        }

        /// <summary>
        /// The possible additional shipments URL
        /// </summary>
        [JsonProperty("possibleAdditionalShipmentsURL")]
        public IEnumerable<Uri>? PossibleAdditionalShipmentsURL { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentTrackingResponseModel() : base()
        {

        }

        #endregion
    }
}
