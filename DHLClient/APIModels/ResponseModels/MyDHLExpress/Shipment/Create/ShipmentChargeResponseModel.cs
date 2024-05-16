using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a shipment charge
    /// </summary>
    public class ShipmentChargeResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceBreakdown"/> property
        /// </summary>
        private IEnumerable<ServiceBreakdownResponseModel>? mServiceBreakdown;

        #endregion

        #region Public Properties

        /// <summary>
        /// The currency type
        /// </summary>
        /// <example>BILLC</example>
        [JsonRequired]
        [JsonProperty("currencyType")]
        [JsonConverter(typeof(CurrencyTypeToStringJsonConverter))]
        public CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        /// <example>USD</example>
        [JsonRequired]
        [JsonProperty("priceCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode PriceCurrency { get; set; }

        /// <summary>
        /// The amount price of DHL product and services
        /// </summary>
        /// <example>147</example>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The service breakdown
        /// </summary>
        [JsonProperty("serviceBreakdown")]
        public IEnumerable<ServiceBreakdownResponseModel> ServiceBreakdown
        {
            get => mServiceBreakdown ?? Enumerable.Empty<ServiceBreakdownResponseModel>();
            set => mServiceBreakdown = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentChargeResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Currency Type: {CurrencyType}, Price Currency: {PriceCurrency}";

        #endregion
    }
}