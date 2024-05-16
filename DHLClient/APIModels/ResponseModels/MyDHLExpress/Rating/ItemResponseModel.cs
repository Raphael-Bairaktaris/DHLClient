using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a product item response
    /// </summary>
    public class ItemResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Breakdown"/> property
        /// </summary>
        private IEnumerable<ItemBreakdownResponseModel>? mBreakdown;

        #endregion

        #region Public Properties

        /// <summary>
        /// Item line number
        /// </summary>
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// The item breakdown
        /// </summary>
        [JsonProperty("breakdown")]
        public IEnumerable<ItemBreakdownResponseModel> Breakdown
        {
            get => mBreakdown ?? Enumerable.Empty<ItemBreakdownResponseModel>();
            set => mBreakdown = value;
        }

        /// <summary>
        /// The date when the rates for DHL products and services is provided
        /// </summary>
        [JsonProperty("pricingDate")]
        public DateOnly PricingDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ItemResponseModel() : base()
        {

        }

        #endregion
    }
}