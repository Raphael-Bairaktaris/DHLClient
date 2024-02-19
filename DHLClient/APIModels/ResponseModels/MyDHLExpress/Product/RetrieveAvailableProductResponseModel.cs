using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an available product response
    /// </summary>
    public class RetrieveAvailableProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Products"/> property
        /// </summary>
        private IEnumerable<RetrieveProductDetailResponseModel>? mProducts;

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        #endregion

        #region Public Properties

        /// <summary>
        /// The product details
        /// </summary>
        [JsonProperty("products")]
        public IEnumerable<RetrieveProductDetailResponseModel> Products
        {
            get => mProducts ?? Enumerable.Empty<RetrieveProductDetailResponseModel>();
            set => mProducts = value;
        }

        /// <summary>
        /// The warnings
        /// </summary>
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
        public RetrieveAvailableProductResponseModel() : base()
        {

        }

        #endregion
    }
}
