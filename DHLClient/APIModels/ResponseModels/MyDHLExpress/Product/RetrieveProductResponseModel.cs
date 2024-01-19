using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The GET Products API will return DHL's product capabilities for a certain set of input data. 
    /// Using the shipper and receiver address as well as the dimension and weight of the piece belonging to a shipment, 
    /// this operation returns the available products.
    /// </summary>
    public class RetrieveProductResponseModel
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
        /// the member of the <see cref="Breakdown"/> property
        /// </summary>
        private ProductBreakdownResponseModel? mBreakdown;

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
        /// The product breakdown
        /// </summary>
        public ProductBreakdownResponseModel? Breadkdown
        {
            get => mBreakdown ??= new ProductBreakdownResponseModel();
            set => mBreakdown = value;
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
        public RetrieveProductResponseModel() : base()
        {

        }

        #endregion
    }
}
