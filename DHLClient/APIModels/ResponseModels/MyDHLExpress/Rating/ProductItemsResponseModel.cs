using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product item breakdown response
    /// </summary>
    public class ProductItemsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Breakdown"/> property
        /// </summary>
        private ProductItemsBreakdownResponseModel? mBreakdown;

        #endregion

        #region Public Properties

        /// <summary>
        /// Item line number 
        /// </summary>
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// The items breakdown
        /// </summary>
        [JsonProperty("breakdown")]
        public ProductItemsBreakdownResponseModel Breakdown
        {
            get => mBreakdown ??= new ProductItemsBreakdownResponseModel();
            set => mBreakdown = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductItemsResponseModel() : base()
        {

        }

        #endregion
    }
}