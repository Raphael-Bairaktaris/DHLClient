using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The base for all the product rating
    /// </summary>
    public class BaseRatingRetrievalResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Products"/> property
        /// </summary>
        private IEnumerable<ProductResponseModel>? mProducts;

        /// <summary>
        /// The member of the <see cref="ExchangeRates"/> property
        /// </summary>
        private IEnumerable<ExchangeRateResponseModel>? mExchangeRates;

        /// <summary>
        /// The member of the <see cref="Warnings"/>
        /// </summary>
        private IEnumerable<string>? mWarnings;

        #endregion

        #region Public Properties

        /// <summary>
        /// The products details
        /// </summary>
        [JsonProperty("products")]
        public IEnumerable<ProductResponseModel> Products
        {
            get => mProducts ?? Enumerable.Empty<ProductResponseModel>();
            set => mProducts = value;
        }

        /// <summary>
        /// The exchange rates
        /// </summary>
        [JsonProperty("exchangeRates")]
        public IEnumerable<ExchangeRateResponseModel> ExchangeRates
        {
            get => mExchangeRates ?? Enumerable.Empty<ExchangeRateResponseModel>();
            set => mExchangeRates = value;
        }

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string> Warnings
        {
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseRatingRetrievalResponseModel() : base()
        {

        }

        #endregion
    }
}
