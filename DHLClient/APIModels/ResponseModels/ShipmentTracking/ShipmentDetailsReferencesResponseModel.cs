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
        /// The number
        /// </summary>
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// The type
        /// </summary>
        [JsonProperty("type")]
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