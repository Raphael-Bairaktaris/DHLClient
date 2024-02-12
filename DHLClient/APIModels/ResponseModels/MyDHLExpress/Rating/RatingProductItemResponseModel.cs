using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product item response
    /// </summary>
    public class RatingProductItemResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Breakdown"/> property
        /// </summary>
        private IEnumerable<ProductItemBreakdownResponseModel>? mBreakdown;

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
        public IEnumerable<ProductItemBreakdownResponseModel> Breakdown
        {
            get => mBreakdown ?? Enumerable.Empty<ProductItemBreakdownResponseModel>();
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
        public RatingProductItemResponseModel() : base()
        {

        }

        #endregion
    }
}