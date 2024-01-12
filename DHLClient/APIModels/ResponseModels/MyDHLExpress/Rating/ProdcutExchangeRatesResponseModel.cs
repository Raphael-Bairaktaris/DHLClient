using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product exchange rate response
    /// </summary>
    public class ProdcutExchangeRatesResponseModel
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
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// The currency code of the base currency is either USD or EUR
        /// </summary>
        [JsonProperty("baseCurrency")]
        public CurrencyCode BaseCurrency { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProdcutExchangeRatesResponseModel() : base()
        {

        }

        #endregion
    }
}