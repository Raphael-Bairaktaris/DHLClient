using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a pre calculated total value
    /// </summary>
    public class PreCalculatedTotalValueRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide the pre-calculated total value of all line items
        /// </summary>
        /// <example>49.43</example>
        [JsonRequired]
        [JsonProperty("preCalculatedTotalGoodsValue")]
        public decimal PreCalculatedTotalGoodsValue { get; set; }

        /// <summary>
        /// Please provide the total value of all line items plus additional charges if any
        /// </summary>
        [JsonRequired]
        [JsonProperty("preCalculatedTotalInvoiceValue")]
        public decimal PreCalculatedTotalInvoiceValue { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PreCalculatedTotalValueRequestModel() : base()
        {

        }

        #endregion
    }
}