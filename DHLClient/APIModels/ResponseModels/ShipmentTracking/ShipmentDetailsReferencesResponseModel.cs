using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details references response
    /// </summary>
    public class ShipmentDetailsReferencesResponseModel
    {
        #region Public Properties

        /// <summary>
        /// A value of reference
        /// </summary>
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// Type of reference
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ReferenceTypeToStringJsonConverter))]
        public ReferenceType Type { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsReferencesResponseModel() : base()
        {

        }

        #endregion
    }
}