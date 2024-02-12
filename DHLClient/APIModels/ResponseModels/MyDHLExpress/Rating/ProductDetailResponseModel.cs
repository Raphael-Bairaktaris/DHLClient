using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents product detail response
    /// </summary>
    public class ProductDetailResponseModel
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
        /// The member of the <see cref="Weight"/> property
        /// </summary>
        private RatingProductWeightResponseModel? mWeight;

        /// <summary>
        /// The member of the <see cref="TotalPrice"/> property
        /// </summary>
        private IEnumerable<RatingProductTotalPriceResponseModel>? mTotalPrice;

        /// <summary>
        /// The member of the <see cref="TotalPriceBreakdown"/> property
        /// </summary>
        private IEnumerable<ProductTotalPriceBreakdownResponseModel>? mTotalPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="DetailedPriceBreakdown"/> property
        /// </summary>
        private IEnumerable<RatingProductDetailedPriceBreakdownResponseModel>? mDetailedPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="ServiceCodeMutuallyExclusiveGroups"/> property
        /// </summary>
        private IEnumerable<RatingProductServiceCodeMutuallyExclusiveGroupResponseModel>? mServiceCodeMutuallyExclusiveGroups;

        /// <summary>
        /// The member of the <see cref="ServiceCodeDependencyRuleGroups"/> property
        /// </summary>
        private IEnumerable<RatingProductServiceCodeDependencyRuleGroupResponseModel>? mServiceCodeDependencyRuleGroups;

        /// <summary>
        /// The member of the <see cref="PickupCapabilities"/> property
        /// </summary>
        private RatingProductPickupCapabilityResponseModel? mPickupCapabilities;

        /// <summary>
        /// The member of the <see cref="DeliveryCapabilities"/> property
        /// </summary>
        private RatingProductDeliveryCapabilityResponseModel? mDeliveryCapabilities;

        /// <summary>
        /// The member of the <see cref="Items"/> property
        /// </summary>
        private IEnumerable<RatingProductItemResponseModel>? mItems;

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
        /// This is the global DHL Express product code for which the delivery is feasible respecting the input data from the request.
        /// </summary>
        /// <example>N</example>
        [JsonProperty("productCode")]
        public string ProductCode
        {
            get => mProductCode ?? string.Empty;
            set => mProductCode = value;
        }

        /// <summary>
        /// This is the local DHL Express product code for which the delivery is feasible respecting the input data from the request.
        /// </summary>
        /// <example>N</example>
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
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode LocalProductCountryCode { get; set; }

        /// <summary>
        /// The NetworkTypeCode element indicates the product belongs to the Day Definite (DD) or Time Definite (TD) network.
        /// </summary>
        [JsonProperty("networkTypeCode")]
        [JsonConverter(typeof(NetworkTypeToStringJsonConverter))]
        public NetworkType NetworkTypeCode { get; set; }

        /// <summary>
        /// Indicator that the product only can be offered to customers with prior agreement.
        /// </summary>
        [JsonProperty("isCustomerAgreement")]
        public bool IsCustomerAgreement { get; set; }

        /// <summary>
        /// The product weight
        /// </summary>
        [JsonProperty("weight")]
        public RatingProductWeightResponseModel Weight
        {
            get => mWeight ??= new RatingProductWeightResponseModel();
            set => mWeight = value;
        }

        /// <summary>
        /// The total price
        /// </summary>
        [JsonProperty("totalPrice")]
        public IEnumerable<RatingProductTotalPriceResponseModel> TotalPrice
        {
            get => mTotalPrice ?? Enumerable.Empty<RatingProductTotalPriceResponseModel>();
            set => mTotalPrice = value;
        }

        /// <summary>
        /// The total price breakdown
        /// </summary>
        [JsonProperty("totalPriceBreakdown")]
        public IEnumerable<ProductTotalPriceBreakdownResponseModel> TotalPriceBreakdown
        {
            get => mTotalPriceBreakdown ??= Enumerable.Empty<ProductTotalPriceBreakdownResponseModel>();
            set => mTotalPriceBreakdown = value;
        }

        /// <summary>
        /// The detailed price breakdown
        /// </summary>
        public IEnumerable<RatingProductDetailedPriceBreakdownResponseModel> DetailedPriceBreakdown
        {
            get => mDetailedPriceBreakdown ?? Enumerable.Empty<RatingProductDetailedPriceBreakdownResponseModel>();
            set => mDetailedPriceBreakdown = value;
        }

        /// <summary>
        /// Group of serviceCodes that are mutually exclusive. Only one serviceCode among the list must be applied for a shipment
        /// </summary>
        [JsonProperty("serviceCodeMutuallyExclusiveGroups")]
        public IEnumerable<RatingProductServiceCodeMutuallyExclusiveGroupResponseModel> ServiceCodeMutuallyExclusiveGroups
        {
            get => mServiceCodeMutuallyExclusiveGroups ?? Enumerable.Empty<RatingProductServiceCodeMutuallyExclusiveGroupResponseModel>();
            set => mServiceCodeMutuallyExclusiveGroups = value;
        }

        /// <summary>
        /// Dependency rule groups for a particular serviceCode.
        /// </summary>
        [JsonProperty("serviceCodeDependencyRuleGroups")]
        public IEnumerable<RatingProductServiceCodeDependencyRuleGroupResponseModel> ServiceCodeDependencyRuleGroups
        {
            get => mServiceCodeDependencyRuleGroups ?? Enumerable.Empty<RatingProductServiceCodeDependencyRuleGroupResponseModel>();
            set => mServiceCodeDependencyRuleGroups = value;
        }

        /// <summary>
        /// The pickup capabilities
        /// </summary>
        [JsonProperty("pickupCapabilities")]
        public RatingProductPickupCapabilityResponseModel PickupCapabilities
        {
            get => mPickupCapabilities ??= new RatingProductPickupCapabilityResponseModel();
            set => mPickupCapabilities = value;
        }

        /// <summary>
        /// The delivery capabilities
        /// </summary>
        public RatingProductDeliveryCapabilityResponseModel DeliveryCapabilities
        {
            get => mDeliveryCapabilities ??= new RatingProductDeliveryCapabilityResponseModel();
            set => mDeliveryCapabilities = value;
        }

        /// <summary>
        /// The items
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<RatingProductItemResponseModel> Items
        {
            get => mItems ?? Enumerable.Empty<RatingProductItemResponseModel>();
            set => mItems = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductDetailResponseModel() : base()
        {

        }

        #endregion
    }
}