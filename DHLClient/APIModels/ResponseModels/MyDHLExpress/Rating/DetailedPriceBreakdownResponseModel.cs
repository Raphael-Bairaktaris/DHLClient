using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a detailed price breakdown response
    /// </summary>
    public class DetailedPriceBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// the member of the <see cref="Breakdown"/> property
        /// </summary>
        private IEnumerable<BreakdownResponseModel>? mBreakdown;

        #endregion

        #region Public Properties

        /// <summary>
        /// The breakdown type
        /// </summary>
        [JsonProperty("currencyType")]
        [JsonConverter(typeof(CurrencyTypeToStringJsonConverter))]
        public CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        [JsonProperty("priceCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode PriceCurrency { get; set; }

        /// <summary>
        /// The breakdown
        /// </summary>
        [JsonProperty("breakdown")]
        public IEnumerable<BreakdownResponseModel> Breakdown
        {
            get => mBreakdown ?? Enumerable.Empty<BreakdownResponseModel>();
            set => mBreakdown = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailedPriceBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}