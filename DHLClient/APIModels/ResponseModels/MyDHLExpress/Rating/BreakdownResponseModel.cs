using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a breakdown response
    /// </summary>
    public class BreakdownResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="ServiceCode"/> property
        /// </summary>
        private string? mServiceCode;

        /// <summary>
        /// The member of the <see cref="LocalServiceCode"/> property
        /// </summary>
        private string? mLocalServiceCode;

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        /// <summary>
        /// The member of the <see cref="PriceBreakdown"/> property
        /// </summary>
        private IEnumerable<PriceBreakdownResponseModel>? mPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="TariffRateFormula"/> property
        /// </summary>
        private string? mTariffRateFormula;

        #endregion

        #region Public Properties

        /// <summary>
        /// When landed-cost is requested then following items name (Charge Types) might be returned
        /// </summary>
        [JsonProperty("name")]
        [JsonConverter(typeof(ChargeTypeToStringJsonConverter))]
        public ChargeType Name { get; set; }

        /// <summary>
        /// Special service or extra charge code. This is the code you would have to use in the /shipment service if you wish to add an optional Service such as Saturday delivery
        /// </summary>
        /// <example>YK</example>
        [JsonProperty("serviceCode")]
        public string ServiceCode
        {
            get => mServiceCode ?? string.Empty;
            set => mServiceCode = value;
        }

        /// <summary>
        /// Local service code
        /// </summary>
        /// <example>YK</example>
        [JsonProperty("localServiceCode")]
        public string LocalServiceCode
        {
            get => mLocalServiceCode ?? string.Empty;
            set => mLocalServiceCode = value;
        }

        /// <summary>
        /// Price breakdown type code
        /// </summary>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        /// <summary>
        /// Special service charge code type for service.
        /// </summary>
        [JsonProperty("serviceTypeCode")]
        [JsonConverter(typeof(SpecialServiceTypeCodeToStringJsonConverter))]
        public SpecialServiceChargeCode ServiceTypeCode { get; set; }

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
        /// Customer agreement indicator for product and services, if service is offered with prior customer agreement
        /// </summary>
        [JsonProperty("isCustomerAgreement")]
        public bool IsCustomerAgreement { get; set; }

        /// <summary>
        /// Indicator if the special service is marketed service
        /// </summary>
        [JsonProperty("isMarketedService")]
        public bool IsMarketedService { get; set; }

        /// <summary>
        /// Indicator if there is any discount allowed
        /// </summary>
        [JsonProperty("isBillingServiceIndicator")]
        public bool IsBillingServiceIndicator { get; set; }

        /// <summary>
        /// The price breakdown
        /// </summary>
        [JsonProperty("priceBreakdown")]
        public IEnumerable<PriceBreakdownResponseModel> PriceBreakdown
        {
            get => mPriceBreakdown ?? Enumerable.Empty<PriceBreakdownResponseModel>();
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