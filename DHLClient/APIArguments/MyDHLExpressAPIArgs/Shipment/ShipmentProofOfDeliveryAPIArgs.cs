using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Arguments used for shipment
    /// </summary>
    public class ShipmentProofOfDeliveryAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        /// <example>9356579890</example>
        [ArgumentName("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// DHL Express customer shipper account number
        /// </summary>
        /// <example>123456789</example>
        [ArgumentName("shipmentAccountNumber")]
        public double ShipmentAccountNumber { get; set; }

        /// <summary>
        /// The content
        /// </summary>
        /// <example>epod-summary</example>
        [ArgumentName("content")]
        [QueryArgumentConverter<ContentTypeQueryArgumentConverter>]
        public ContentType Content { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentProofOfDeliveryAPIArgs() : base()
        {

        }

        #endregion
    }
}
