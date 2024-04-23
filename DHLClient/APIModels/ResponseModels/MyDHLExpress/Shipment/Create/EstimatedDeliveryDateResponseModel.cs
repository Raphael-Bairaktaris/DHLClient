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
        /// <example>2021-09-27</example>
        [JsonProperty("estimatedDeliveryDate")]
        public DateOnly EstimatedDeliveryDate { get; set; }

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
    }
}