using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a my dhl rating product total price breakdown response model
    /// </summary>
    public class ProductTotalPriceBreakdownResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Possible Values
        /// <list type="bullet|number|table">
        ///     <item>BILLC</item>
        ///     <item>PULCL</item>
        ///     <item>BASEC</item>
        /// </list>
        /// </summary>
        [JsonProperty("currencyType")]
        public CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        [JsonProperty("priceCurrency")]
        public CurrencyCode PriceCurrency { get; set; }

        /// <summary>
        /// The price breakdown
        /// </summary>
        [JsonProperty("priceBreakdown")]
        public ProductPriceBreakDownResponseModel PriceBreakdown { get; set; }

        /// <summary>
        /// The detailed price breakdown
        /// </summary>
        public ProductDetailedPriceBreakdownResponseModel DetailedPriceBreakdown { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductTotalPriceBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}
