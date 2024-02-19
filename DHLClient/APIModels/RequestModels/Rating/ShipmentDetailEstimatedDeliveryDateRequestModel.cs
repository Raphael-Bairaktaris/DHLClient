using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an estimated delivery date
    /// </summary>
    public class ShipmentDetailEstimatedDeliveryDateRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please indicate if requesting to get EDD for this shipment.
        /// </summary>
        [JsonRequired]
        [JsonProperty("isRequested")]
        public bool IsRequested { get; set; }

        /// <summary>
        /// Please indicate the EDD type being requested
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(DeliveryTypeToStringJsonConverter))]
        public DeliveryType TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailEstimatedDeliveryDateRequestModel() : base()
        {

        }

        #endregion
    }
}