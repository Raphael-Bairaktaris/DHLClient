using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a commodity code
    /// </summary>
    public class ShipmentLineItemCommodityCodeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide type of the commodity code
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(CommodityCodeTypeToStringJsonConverter))]
        public CommodityCodeType? TypeCode { get; set; }

        /// <summary>
        /// Please provide Commodity codes for the shipment at item line level
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentLineItemCommodityCodeRequestModel() : base()
        {

        }

        #endregion
    }
}