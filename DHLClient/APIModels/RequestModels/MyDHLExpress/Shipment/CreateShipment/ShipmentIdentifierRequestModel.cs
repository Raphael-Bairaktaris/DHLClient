using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment identifier
    /// </summary>
    public class ShipmentIdentifierRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Identifiers section is on the shipment level where you can optionally provide a DHL Express waybill number. This has to be enabled by your DHL Express IT contact.
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ShipmentAttributeToStringJsonConverter))]
        public ShipmentAttribute? TypeCode { get; set; }

        /// <summary>
        /// Please enter value of your identifier (WB number, PieceID)
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Please enter value of Piece Data Identifier.
        /// Note: Piece identification data should be same for all the pieces provided in single shipment
        /// </summary>
        [JsonProperty("dataIdentifier")]
        public string? DataIdentifier { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentIdentifierRequestModel() : base()
        {

        }

        #endregion
    }
}