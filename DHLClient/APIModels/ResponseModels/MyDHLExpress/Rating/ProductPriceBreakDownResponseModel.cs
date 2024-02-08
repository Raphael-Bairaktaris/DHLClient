using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a rating product price breakdown response 
    /// </summary>
    public class ProductPriceBreakDownResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Expected values in breakdown
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(TypeCodeToStringJsonConverter))]
        public BreakdownType TypeCode { get; set; }

        /// <summary>
        /// The amount price of DHL product and services
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductPriceBreakDownResponseModel() : base()
        {

        }

        #endregion
    }
}