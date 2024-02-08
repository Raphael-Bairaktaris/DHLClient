using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a my dhl rating product total price response
    /// </summary>
    public class ProductTotalPriceResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Possible values
        /// <list type="bullet|number|table">
        ///     <item>BILLC</item>
        ///     <item>PULCL</item>
        ///     <item>BASEC</item>
        /// </list>
        /// </summary>
        [JsonProperty("currencyType")]
        [JsonConverter(typeof(CurrencyTypeToStringJsonConverter))]
        public CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        [JsonProperty("priceCurrency")]
        public CurrencyCode PriceCurrency { get; set; }

        /// <summary>
        /// This is the total price of the rated shipment for the product listed.
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductTotalPriceResponseModel() : base()
        {

        }

        #endregion
    }
}
