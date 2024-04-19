using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product total price response
    /// </summary>
    public class TotalPriceResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The currency Type
        /// </summary>
        /// <example>BILLC</example>
        [JsonProperty("currencyType")]
        [JsonConverter(typeof(CurrencyTypeToStringJsonConverter))]
        public CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        /// <example>GBP</example>
        [JsonProperty("currencyCode")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        /// <summary>
        /// This is the total price of the rated shipment for the product listed. 
        /// </summary>
        /// <example>141.51</example>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TotalPriceResponseModel() : base()
        {

        }

        #endregion
    }
}