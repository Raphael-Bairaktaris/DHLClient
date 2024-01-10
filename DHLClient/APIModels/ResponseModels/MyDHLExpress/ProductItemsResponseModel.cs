using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// represent a product item response
    /// </summary>
    public class ProductItemsResponseModel
    {
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
        public ProductItemsBreakdownResponseModel Breakdown { get; set; }

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