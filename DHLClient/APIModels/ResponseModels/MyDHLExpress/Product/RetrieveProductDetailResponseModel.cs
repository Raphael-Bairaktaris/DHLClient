using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a product detail response 
    /// </summary>
    public class RetrieveProductDetailResponseModel : ProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Breakdown"/> property
        /// </summary>
        private IEnumerable<ProductBreakdownResponseModel>? mBreakdown;

        #endregion

        #region Public Properties

        /// <summary>
        /// The breakdown
        /// </summary>
        [JsonProperty("breakdown")]
        public IEnumerable<ProductBreakdownResponseModel> Breakdown
        {
            get => mBreakdown ?? Enumerable.Empty<ProductBreakdownResponseModel>();
            set => mBreakdown = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RetrieveProductDetailResponseModel() : base()
        {

        }

        #endregion
    }
}