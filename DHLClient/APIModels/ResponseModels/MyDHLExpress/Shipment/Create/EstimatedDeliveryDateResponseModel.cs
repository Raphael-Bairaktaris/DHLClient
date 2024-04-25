using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an estimated delivery date
    /// </summary>
    public class EstimatedDeliveryDateResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The estimated delivery date
        /// </summary>
        /// <example>2022-12-28T23:59:00Z</example>
        [JsonProperty("estimatedDeliveryDate")]
        public DateTimeOffset EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The estimated delivery type
        /// </summary>
        /// <example>QDDC</example>
        [JsonProperty("estimatedDeliveryType")]
        [JsonConverter(typeof(DeliveryTypeToStringJsonConverter))]
        public DeliveryType EstimatedDeliveryType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EstimatedDeliveryDateResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Estimated Delivery Date: {EstimatedDeliveryDate}, Estimated Delivery Type: {EstimatedDeliveryType}";

        #endregion
    }
}