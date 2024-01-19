using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Arguments used for shipment
    /// </summary>
    public class ShipmentAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        /// <example>9356579890</example>
        [JsonRequired]
        [JsonProperty("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// DHL Express customer shipper account number
        /// </summary>
        /// <example>123456789</example>
        [JsonProperty("shipmentAccountNumber")]
        public double ShipmentAccountNumber { get; set; }

        /// <summary>
        /// The content
        /// </summary>
        /// <example>epod-summary</example>
        [JsonProperty("content")]
        public string? Content { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentAPIArgs() : base()
        {

        }

        #endregion
    }
}
