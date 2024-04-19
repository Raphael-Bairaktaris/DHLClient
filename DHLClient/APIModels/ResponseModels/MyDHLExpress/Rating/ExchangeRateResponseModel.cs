using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product exchange rate
    /// </summary>
    public class ExchangeRateResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="BaseCurrency"/> property
        /// </summary>
        private CurrencyCode mBaseCurrency;

        #endregion

        #region Public Properties

        /// <summary>
        /// Rate of the currency exchange
        /// </summary>
        /// <example>1.188411</example>
        [JsonProperty("currentExchangeRate")]
        public decimal CurrentExchangeRate { get; set; }

        /// <summary>
        /// The currency code
        /// </summary>
        /// <example>GBP</example>
        [JsonProperty("currency")]
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// The currency code of the base currency is either USD or EUR
        /// </summary>
        /// <example>EUR</example>
        [JsonProperty("baseCurrency")]
        public CurrencyCode BaseCurrency
        {
            get { return mBaseCurrency; }
            set
            {
                if (value == CurrencyCode.USD || value == CurrencyCode.EUR)
                {
                    mBaseCurrency = value;
                }
                else
                    throw new ArgumentException("Invalid currency code. Only USD and EUR are allowed.");
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExchangeRateResponseModel() : base()
        {

        }

        #endregion
    }
}