using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The product items breakdown response
    /// </summary>
    public class ProductItemsBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="LocalServiceCode"/> property
        /// </summary>
        private string? mLocalServiceCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name of the charge
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// Special service or extra charge code. This is the code you would have to use in the 
        /// /shipment service if you wish to add an optional Service such as Saturday delivery
        /// </summary>
        public SpecialServiceChargeCode ServiceCode { get; set; }

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
        public ChargeCategory TypeCode { get; set; }

        /// <summary>
        /// Special service charge code type for service.
        /// </summary>
        [JsonProperty("serviceTypeCode")]
        public SpecialServiceChargeCode ServiceTypeCode { get; set; }

        /// <summary>
        /// The charge amount of the line item charge.
        /// </summary>
        public decimal Number { get; set; }

        /// <summary>
        /// This the currency of the rated shipment for the prices listed.
        /// </summary>
        [JsonProperty("priceCurrency")]
        public CurrencyType PriceCurrency { get; set; }

        /// <summary>
        /// Customer agreement indicator for product and services, if service is offered with prior customer agreement
        /// </summary>
        [JsonProperty("isCustomerAggrement")]
        public bool IsCustomerAggreement { get; set; }

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
        public ProductItemsBreakdownResponseModel() : base()
        {

        }

        #endregion
    }
}