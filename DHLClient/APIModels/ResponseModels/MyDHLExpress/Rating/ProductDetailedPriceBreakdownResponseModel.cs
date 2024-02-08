using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// represents a rating product detailed price breakdown response 
    /// </summary>
    public class ProductDetailedPriceBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceCode"/> property
        /// </summary>
        private string? mServiceCode;

        /// <summary>
        /// The member of the <see cref="LocalServiceCode"/> property
        /// </summary>
        private string? mLocalServiceCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// When landed-cost is requested then following items name (Charge Types) might be returned
        /// </summary>
        [JsonProperty("name")]
        public TotalChargeType Name { get; set; }

        /// <summary>
        /// Special service or extra charge code. This is the code you would have to use in the
        /// /shipment service if you wish to add an optional Service such as Saturday delivery
        /// </summary>
        public string ServiceCode
        {
            get => mServiceCode ?? string.Empty;
            set => mServiceCode = value;
        }

        /// <summary>
        /// The local service code
        /// </summary>
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
        public BreakdownType TypeCode { get; set; }

        /// <summary>
        /// Special service charge code type for service. 
        /// </summary>
        [JsonProperty("serviceTypeCode")]
        public SpecialServiceChargeCode ServiceTypeCode { get; set; }

        /// <summary>
        /// The price breakdown value
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        [JsonProperty("priceCurrency")]
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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductDetailedPriceBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}