using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating identifiers
    /// </summary>
    public class ShipmentDetailIdentifiersRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide type of the identifier you want to set value for
        /// </summary>
        /// <example>shipmentId</example>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ShipmentAttributeToStringJsonConverter))]
        public ShipmentAttribute? TypeCode { get; set; }

        /// <summary>
        /// Please enter value of your identifier (WB number, PieceID)
        /// </summary>
        /// <example>1234567890</example>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Please enter value of Piece Data Identifier. 
        /// Note: Piece identification data should be same for all the pieces provided in single shipment.
        /// </summary>
        [JsonProperty("dataIdentifier")]
        public string? DataIdentifier { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailIdentifiersRequestModel() : base()
        {

        }

        #endregion
    }
}