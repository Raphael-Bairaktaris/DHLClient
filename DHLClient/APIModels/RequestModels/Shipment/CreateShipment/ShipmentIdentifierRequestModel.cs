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
        /// Identifiers section is on the shipment level where you can optionaly provide a DHL Express waybill number. This has to be enabled by your DHL Express IT contact.
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ShipmentAttributeToStringJsonConverter))]
        public ShipmentAttribute TypeCode { get; set; }

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