using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product exchange rate response
    /// </summary>
    public class ProductExchangeRateResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Rate of the currency exchange
        /// </summary>
        [JsonProperty("currentExchangeRate")]
        public decimal CurrentExchangeRate { get; set; }

        /// <summary>
        /// The currency code
        /// </summary>
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// The currency code of the base currency is either USD or EUR
        /// </summary>
        [JsonProperty("baseCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode BaseCurrency { get; set; } = CurrencyCode.EUR;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductExchangeRateResponseModel() : base()
        {

        }

        #endregion
    }
}