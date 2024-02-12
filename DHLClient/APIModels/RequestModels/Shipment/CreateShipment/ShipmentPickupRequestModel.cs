using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment pickup
    /// </summary>
    public class ShipmentPickupRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please advise if a pickup is needed for this shipment
        /// </summary>
        [JsonRequired]
        [JsonProperty("isRequested")]
        public bool IsRequested { get; set; }

        /// <summary>
        /// The latest time the location premises is available to dispatch the DHL Express shipment.
        /// </summary>
        /// <example>HH:MM</example>
        [JsonProperty("closeTime")]
        public DateTime? CloseTime { get; set; }

        /// <summary>
        /// Provides information on where the package should be picked up by DHL courier.
        /// </summary>
        /// <example>reception</example>
        [JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Details special pickup instructions you may wish to send to the DHL Courier.
        /// </summary>
        [JsonProperty("specialInstructions")]
        public IEnumerable<ShipmentSpecialInstructionRequestModel>? SpecialInstructions { get; set; }

        /// <summary>
        /// Please enter address and contact details related to your pickup
        /// </summary>
        [JsonProperty("pickupDetails")]
        public ShipmentPickupDetailRequestModel? PickupDetails { get; set; }

        /// <summary>
        /// Please enter address and contact details of the individual requesting the pickup
        /// </summary>
        [JsonProperty("pickupRequestorDetails")]
        public ShipmentPickupDetailRequestModel? PickupRequestorDetails { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        [JsonRequired]
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Local Product code. Important when shipping domestic products.
        /// </summary>
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

        /// <summary>
        /// Please advise if you want to get rate estimates for given shipment
        /// </summary>
        [JsonProperty("getRateEstimates")]
        public bool GetRateEstimates { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>
        [JsonRequired]
        [JsonProperty("accounts")]
        public AccountRequestModel? Accounts { get; set; }

        /// <summary>
        /// This section communicates additional shipping services, such as Insurance (or Shipment Value Protection).
        /// </summary>
        [JsonRequired]
        [JsonProperty("valueAddedServices")]
        public ShipmentValueAddedServiceRequestModel? ValueAddedServices { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentPickupRequestModel() : base()
        {

        }

        #endregion
    }
}