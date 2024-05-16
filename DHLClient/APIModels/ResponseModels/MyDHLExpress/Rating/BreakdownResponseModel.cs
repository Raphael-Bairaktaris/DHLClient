using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a breakdown response
    /// </summary>
    public class BreakdownResponseModel : ProductBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PriceBreakdown"/> property
        /// </summary>
        private IEnumerable<RatingBreakdownResponseModel>? mPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="TariffRateFormula"/> property
        /// </summary>
        private string? mTariffRateFormula;

        #endregion

        #region Public Properties

        /// <summary>
        /// Price breakdown value
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        /// <example>GBP</example>
        [JsonProperty("priceCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode PriceCurrency { get; set; }

        /// <summary>
        /// The price breakdown
        /// </summary>
        [JsonProperty("priceBreakdown")]
        public IEnumerable<RatingBreakdownResponseModel> PriceBreakdown
        {
            get => mPriceBreakdown ?? Enumerable.Empty<RatingBreakdownResponseModel>();
            set => mPriceBreakdown = value;
        }

        /// <summary>
        /// Tariff Rate Formula on Shipment Level
        /// </summary>
        [JsonProperty("tariffRateFormula")]
        public string TariffRateFormula
        {
            get => mTariffRateFormula ?? string.Empty;
            set => mTariffRateFormula = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}