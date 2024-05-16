using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a shipment estimated delivery time frame response
    /// </summary>
    public class ShipmentDetailEstimatedDeliveryTimeFrameResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The estimated delivery time from
        /// </summary>
        /// <example> 2018-08-03T00:00:00Z </example>
        [JsonProperty("estimatedFrom")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimestampJsonConverter))]
        public DateTimeOffset EstimatedFrom { get; set; }

        /// <summary>
        /// The estimated delivery time through
        /// </summary>
        /// <example> 2018-08-03T00:00:00Z </example>
        [JsonProperty("estimatedThrough")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimestampJsonConverter))]
        public DateTimeOffset EstimatedThrough { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailEstimatedDeliveryTimeFrameResponseModel() : base()
        {

        }

        #endregion
    }
}
