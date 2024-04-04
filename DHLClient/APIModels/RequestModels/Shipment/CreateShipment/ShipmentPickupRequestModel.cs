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
        public TimeOnly? CloseTime { get; set; }

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