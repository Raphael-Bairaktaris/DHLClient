using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a commodity code
    /// </summary>
    public class ShipmentDetailCommodityCodeRquestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide type of the commodity code
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(CommodityCodeToStringJsonConverter))]
        public CommodityCode? TypeCode { get; set; }

        /// <summary>
        /// Please provide the commodity code
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailCommodityCodeRquestModel() : base()
        {

        }

        #endregion
    }
}