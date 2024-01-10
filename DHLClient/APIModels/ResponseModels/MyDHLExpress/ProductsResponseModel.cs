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
        public string NetworkTypeCode { get; set; }

        /// <summary>
        /// Indicator that the product only can be offered to customers with prior agreement.
        /// </summary>
        [JsonProperty("isCustomerAgreement")]
        public bool IsCustomerAgreement { get; set; }

        /// <summary>
        /// The product weight
        /// </summary>
        [JsonProperty("weight")]
        public ProductWeightResponseModel Weight { get; set; }

        /// <summary>
        /// The total price
        /// </summary>
        [JsonProperty("totalPrice")]
        public ProductTotalPriceResponseModel TotalPrice { get; set; }

        /// <summary>
        /// The total price breakdown
        /// </summary>
        [JsonProperty("totalPriceBreakdown")]
        public ProductTotalPriceBreakdownResponseModel TotalPriceBreakdown { get; set; }

        /// <summary>
        /// The detailed price breakdown
        /// </summary>
        [JsonProperty("detailedPriceBreakdown")]
        public ProductDetailedPriceBreakdownResponseModel DetailedPriceBreakdown { get; set; }

        /// <summary>
        /// Group of serviceCodes that are mutually exclusive. Only one serviceCode among the list must be applied for a shipment
        /// </summary>
        public ProductServiceCodeMutuallyExclusiveGroupsResponseModel ServiceCodeMutuallyExcluseiveGroups { get; set; }

        /// <summary>
        /// Dependency rule groups for a particular serviceCode.
        /// </summary>
        public ProductServiceCodeDependencyRuleGroupsResponseModel ServiceCodeDependencyRuleGroups { get; set; }

        /// <summary>
        /// The product pickup capabilities
        /// </summary>
        [JsonProperty("pickupCapabilities")]
        public ProductPickupCapabilitiesResponseModel PickupCapabilities { get; set; }

        /// <summary>
        /// The product delivery capabilities
        /// </summary>
        [JsonProperty("deliveryCapabilities")]
        public ProductDeliveryCapabilitiesResponseModel DeliveryCapabilities { get; set; }

        /// <summary>
        /// The product items
        /// </summary>
        [JsonProperty("items")]
        public ProductItemsResponseModel Items { get; set; }

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