using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product item breakdown response
    /// </summary>
    public class ItemBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="ServiceCode"/> property
        /// </summary>
        private string? mServiceCode;

        /// <summary>
        /// The member of the <see cref="LocalServiceCode"/> property
        /// </summary>
        private string? mLocalServiceCode;

        /// <summary>
        /// The member of the <see cref="PriceBreakdown"/> property
        /// </summary>
        private IEnumerable<ItemPriceBreakdownResponseModel>? mPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="TariffRateFormula"/> property
        /// </summary>
        private string? mTariffRateFormula;

        #endregion

        #region Public Properties

        /// <summary>
        /// Name of the charge
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// Special service or extra charge code. This is the code you would have to use in the /shipment service if you wish to add an optional Service such as Saturday delivery
        /// </summary>
        [JsonProperty("serviceCode")]
        public string ServiceCode
        {
            get => mServiceCode ?? string.Empty;
            set => mServiceCode = value;
        }

        /// <summary>
        /// Local service code
        /// </summary>
        [JsonProperty("localServiceCode")]
        public string LocalServiceCode
        {
            get => mLocalServiceCode ?? string.Empty;
            set => mLocalServiceCode = value;
        }

        /// <summary>
        /// Charge type or category.
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ChargeCategoryToStringJsonConverter))]
        public ChargeCategory TypeCode { get; set; }

        /// <summary>
        /// Special service charge code type for service.
        /// </summary>
        [JsonProperty("serviceTypeCode")]
        [JsonConverter(typeof(SpecialServiceChargeCodeToStringJsonConverter))]
        public SpecialServiceChargeCode ServiceTypeCode { get; set; }

        /// <summary>
        /// The charge amount of the line item charge.
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
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
        /// The item price breakdown
        /// </summary>
        [JsonProperty("priceBreakdown")]
        public IEnumerable<ItemPriceBreakdownResponseModel> PriceBreakdown
        {
            get => mPriceBreakdown ?? Enumerable.Empty<ItemPriceBreakdownResponseModel>();
            set => mPriceBreakdown = value;
        }

        /// <summary>
        /// Tariff Rate Formula on Line Item Level
        /// </summary>
        [JsonProperty("tarriffRateFormula")]
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
        public ItemBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}