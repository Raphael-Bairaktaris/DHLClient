using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a dhl rating product response
    /// </summary>
    public class ProductsResponseModel : RetrieveProductResponseModel
    {
        #region Private Members

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
        /// The member of the <see cref="Items"/> property
        /// </summary>
        private IEnumerable<ProductItemsResponseModel>? mItems;

        /// <summary>
        /// The member of the <see cref="ExchangeRates"/> property 
        /// </summary>
        private IEnumerable<ProdcutExchangeRatesResponseModel>? mExchangeRates;

        #endregion

        #region Public Properties

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