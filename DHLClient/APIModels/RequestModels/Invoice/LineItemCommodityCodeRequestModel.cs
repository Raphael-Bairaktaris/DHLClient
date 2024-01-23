using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a commodity code
    /// </summary>
    public class LineItemCommodityCodeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide type of the commodity code
        /// </summary>
        /// <example>outbound</example>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public CommodityCodeType? TypeCode { get; set; }

        /// <summary>
        /// Please provide the commodity code 
        /// </summary>
        /// <example>851713</example>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LineItemCommodityCodeRequestModel() : base()
        {

        }

        #endregion
    }
}