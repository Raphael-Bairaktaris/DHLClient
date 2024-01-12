using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a dhl rating product response
    /// </summary>
    public class ProductsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ProductName"/> property
        /// </summary>
        private string? mProductName;

        /// <summary>
        /// The member of the <see cref="ProductCode"/> property
        /// </summary>
        private string? mProductCode;

        /// <summary>
        /// The member of the <see cref="LocalProductCode"/> property
        /// </summary>
        private string? mLocalProductCode;

        /// <summary>
        /// The member of the <see cref="NetworkTypeCode"/> property
        /// </summary>
        private string? mNetworkTypeCode;

        /// <summary>
        /// The member of the <see cref="Weight"/> property
        /// </summary>
        private ProductWeightResponseModel? mWeight;

        /// <summary>
        /// The member of the <see cref="TotalPrice"/> property
        /// </summary>
        private ProductTotalPriceResponseModel? mTotalPrice;

        /// <summary>
        /// The member of the <see cref="mTotalPrice"/> property
        /// </summary>
        private ProductTotalPriceBreakdownResponseModel? mTotalPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="DetailedPriceBreakdown"/> property
        /// </summary>
        private ProductDetailedPriceBreakdownResponseModel? mDetailedPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="ServiceCodeMutuallyExclusiveGroups"/> property
        /// </summary>
        private IEnumerable<ProductServiceCodeMutuallyExclusiveGroupsResponseModel>? mServiceCodeMutuallyExclusiveGroups;

        /// <summary>
        /// The member of the <see cref="ServiceCodeDependencyRuleGroups"/> property
        /// </summary>
        private IEnumerable<ProductServiceCodeDependencyRuleGroupsResponseModel>? mServiceCodeDependencyRuleGroups;

        /// <summary>
        /// The member of the <see cref="PickupCapabilities"/> property
        /// </summary>
        private IEnumerable<ProductPickupCapabilitiesResponseModel>? mPickupCapabilities;

        /// <summary>
        /// The member of the <see cref="DeliveryCapabilities"/> property
        /// </summary>
        private IEnumerable<ProductDeliveryCapabilitiesResponseModel>? mDeliveryCapabilities;

        /// <summary>
        /// The member of the <see cref="Items"/> property
        /// </summary>
        private IEnumerable<ProductItemsResponseModel>? mItems;

        /// <summary>
        /// The member of the <see cref="ExchangeRates"/> property 
        /// </summary>
        private IEnumerable<ProdcutExchangeRatesResponseModel>? mExchangeRates;

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        #endregion

        #region Public Properties

        /// <summary>
        /// Name of the DHL Express product
        /// </summary>
        /// <example>EXPRESS DOMESTIC</example>
        [JsonProperty("productName")]
        public string ProductName
        {
            get => mProductName ?? string.Empty;
            set => mProductName = value;
        }

        /// <summary>
        /// This is the global DHL Express product code for which the delivery is feasible respecting the input data from the request 
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode
        {
            get => mProductCode ?? string.Empty;
            set => mProductCode = value;
        }

        /// <summary>
        /// This is the local DHL Express product code for which the delivery is feasible respecting the input data from the request.
        /// </summary>
        [JsonProperty("localProductCode")]
        public string LocalProductCode
        {
            get => mLocalProductCode ?? string.Empty;
            set => mLocalProductCode = value;
        }

        /// <summary>
        /// The country code for the local service used
        /// </summary>
        [JsonProperty("localProductCountryCode")]
        public CountryCode LocalProductCountryCode { get; set; }

        /// <summary>
        /// The NetworkTypeCode element indicates the product belongs to the Day Definite (DD) or Time Definite (TD) network.
        /// </summary>
        [JsonProperty("networkTypeCode")]
        public string NetworkTypeCode
        {
            get => mNetworkTypeCode ?? string.Empty;
            set => mNetworkTypeCode = value;
        }

        /// <summary>
        /// Indicator that the product only can be offered to customers with prior agreement.
        /// </summary>
        [JsonProperty("isCustomerAgreement")]
        public bool IsCustomerAgreement { get; set; }

        /// <summary>
        /// The product weight
        /// </summary>
        [JsonProperty("weight")]
        public ProductWeightResponseModel Weight
        {
            get => mWeight ??= new ProductWeightResponseModel();
            set => mWeight = value;
        }

        /// <summary>
        /// The total price
        /// </summary>
        [JsonProperty("totalPrice")]
        public ProductTotalPriceResponseModel TotalPrice
        {
            get => mTotalPrice ??= new ProductTotalPriceResponseModel();
            set => mTotalPrice = value;
        }

        /// <summary>
        /// The total price breakdown
        /// </summary>
        [JsonProperty("totalPriceBreakdown")]
        public ProductTotalPriceBreakdownResponseModel TotalPriceBreakdown
        {
            get => mTotalPriceBreakdown ??= new ProductTotalPriceBreakdownResponseModel();
            set => mTotalPriceBreakdown = value;
        }

        /// <summary>
        /// The detailed price breakdown
        /// </summary>
        [JsonProperty("detailedPriceBreakdown")]
        public ProductDetailedPriceBreakdownResponseModel DetailedPriceBreakdown
        {
            get => mDetailedPriceBreakdown ??= new ProductDetailedPriceBreakdownResponseModel();
            set => mDetailedPriceBreakdown = value;
        }

        /// <summary>
        /// Group of serviceCodes that are mutually exclusive. Only one serviceCode among the list must be applied for a shipment
        /// </summary>
        [JsonProperty("serviceCodeMutuallyExclusiveGroups")]
        public IEnumerable<ProductServiceCodeMutuallyExclusiveGroupsResponseModel> ServiceCodeMutuallyExclusiveGroups
        {
            get => mServiceCodeMutuallyExclusiveGroups ?? Enumerable.Empty<ProductServiceCodeMutuallyExclusiveGroupsResponseModel>();
            set => mServiceCodeMutuallyExclusiveGroups = value;
        }

        /// <summary>
        /// Dependency rule groups for a particular serviceCode.
        /// </summary>
        public IEnumerable<ProductServiceCodeDependencyRuleGroupsResponseModel> ServiceCodeDependencyRuleGroups
        {
            get => mServiceCodeDependencyRuleGroups ?? Enumerable.Empty<ProductServiceCodeDependencyRuleGroupsResponseModel>();
            set => mServiceCodeDependencyRuleGroups = value;
        }

        /// <summary>
        /// The product pickup capabilities
        /// </summary>
        [JsonProperty("pickupCapabilities")]
        public IEnumerable<ProductPickupCapabilitiesResponseModel> PickupCapabilities
        {
            get => mPickupCapabilities ?? Enumerable.Empty<ProductPickupCapabilitiesResponseModel>();
            set => mPickupCapabilities = value;
        }

        /// <summary>
        /// The product delivery capabilities
        /// </summary>
        [JsonProperty("deliveryCapabilities")]
        public IEnumerable<ProductDeliveryCapabilitiesResponseModel> DeliveryCapabilities
        {
            get => mDeliveryCapabilities ?? Enumerable.Empty<ProductDeliveryCapabilitiesResponseModel>();
            set => mDeliveryCapabilities = value;
        }

        /// <summary>
        /// The product items
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<ProductItemsResponseModel> Items
        {
            get => mItems ?? Enumerable.Empty<ProductItemsResponseModel>();
            set => mItems = value;
        }

        /// <summary>
        /// The date when the rates for DHL products and services is provided
        /// </summary>
        [JsonProperty("pricingDate")]
        public DateOnly PricingDate { get; set; }

        /// <summary>
        /// The exchange rates
        /// </summary>
        [JsonProperty("exchangeRates")]
        public IEnumerable<ProdcutExchangeRatesResponseModel> ExchangeRates
        {
            get => mExchangeRates ?? Enumerable.Empty<ProdcutExchangeRatesResponseModel>();
            set => mExchangeRates = value;
        }

        /// <summary>
        /// The warnings
        /// </summary>
        /// <example> Price can't be calculated </example>
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
        public ProductsResponseModel() : base()
        {

        }

        #endregion
    }
}