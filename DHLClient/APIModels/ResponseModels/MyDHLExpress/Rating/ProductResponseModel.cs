using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents product details
    /// </summary>
    public class ProductResponseModel
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
        private WeightResponseModel? mWeight;

        /// <summary>
        /// The member of the <see cref="TotalPrice"/> property
        /// </summary>
        private IEnumerable<TotalPriceResponseModel>? mTotalPrice;

        /// <summary>
        /// The member of the <see cref="TotalPriceBreakdown"/> property
        /// </summary>
        private IEnumerable<ProductTotalPriceBreakdownResponseModel>? mTotalPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="DetailedPriceBreakdown"/> property
        /// </summary>
        private IEnumerable<DetailedPriceBreakdownResponseModel>? mDetailedPriceBreakdown;

        /// <summary>
        /// The member of the <see cref="ServiceCodeMutuallyExclusiveGroups"/> property
        /// </summary>
        private IEnumerable<ServiceCodeMutuallyExclusiveGroupResponseModel>? mServiceCodeMutuallyExclusiveGroups;

        /// <summary>
        /// The member of the <see cref="ServiceCodeDependencyRuleGroups"/> property
        /// </summary>
        private IEnumerable<ServiceCodeDependencyRuleGroupResponseModel>? mServiceCodeDependencyRuleGroups;

        /// <summary>
        /// The member of the <see cref="PickupCapabilities"/> property
        /// </summary>
        private PickupCapabilityResponseModel? mPickupCapabilities;

        /// <summary>
        /// The member of the <see cref="DeliveryCapabilities"/> property
        /// </summary>
        private DeliveryCapabilityResponseModel? mDeliveryCapabilities;

        /// <summary>
        /// The member of the <see cref="Items"/> property
        /// </summary>
        private IEnumerable<ItemResponseModel>? mItems;

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
        public WeightResponseModel Weight
        {
            get => mWeight ??= new WeightResponseModel();
            set => mWeight = value;
        }

        /// <summary>
        /// The total price
        /// </summary>
        [JsonProperty("totalPrice")]
        public IEnumerable<TotalPriceResponseModel> TotalPrice
        {
            get => mTotalPrice ?? Enumerable.Empty<TotalPriceResponseModel>();
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
        [JsonProperty("detailedPriceBreakdown")]
        public IEnumerable<DetailedPriceBreakdownResponseModel> DetailedPriceBreakdown
        {
            get => mDetailedPriceBreakdown ?? Enumerable.Empty<DetailedPriceBreakdownResponseModel>();
            set => mDetailedPriceBreakdown = value;
        }

        /// <summary>
        /// Group of serviceCodes that are mutually exclusive. Only one serviceCode among the list must be applied for a shipment
        /// </summary>
        [JsonProperty("serviceCodeMutuallyExclusiveGroups")]
        public IEnumerable<ServiceCodeMutuallyExclusiveGroupResponseModel> ServiceCodeMutuallyExclusiveGroups
        {
            get => mServiceCodeMutuallyExclusiveGroups ?? Enumerable.Empty<ServiceCodeMutuallyExclusiveGroupResponseModel>();
            set => mServiceCodeMutuallyExclusiveGroups = value;
        }

        /// <summary>
        /// Dependency rule groups for a particular serviceCode.
        /// </summary>
        [JsonProperty("serviceCodeDependencyRuleGroups")]
        public IEnumerable<ServiceCodeDependencyRuleGroupResponseModel> ServiceCodeDependencyRuleGroups
        {
            get => mServiceCodeDependencyRuleGroups ?? Enumerable.Empty<ServiceCodeDependencyRuleGroupResponseModel>();
            set => mServiceCodeDependencyRuleGroups = value;
        }

        /// <summary>
        /// The pickup capabilities
        /// </summary>
        [JsonProperty("pickupCapabilities")]
        public PickupCapabilityResponseModel PickupCapabilities
        {
            get => mPickupCapabilities ??= new PickupCapabilityResponseModel();
            set => mPickupCapabilities = value;
        }

        /// <summary>
        /// The delivery capabilities
        /// </summary>
        [JsonProperty("deliveryCapabilities")]
        public DeliveryCapabilityResponseModel DeliveryCapabilities
        {
            get => mDeliveryCapabilities ??= new DeliveryCapabilityResponseModel();
            set => mDeliveryCapabilities = value;
        }

        /// <summary>
        /// The items
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<ItemResponseModel> Items
        {
            get => mItems ?? Enumerable.Empty<ItemResponseModel>();
            set => mItems = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Product Name: {ProductName}";

        #endregion
    }
}