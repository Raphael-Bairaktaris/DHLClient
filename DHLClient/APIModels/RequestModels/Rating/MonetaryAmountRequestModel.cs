using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a monetary amount
    /// </summary>
    public class MonetaryAmountRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide the monetary amount type
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public MonetaryAmountType TypeCode { get; set; }

        /// <summary>
        /// Please provide the monetary value
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Please provide monetary amount currency code
        /// </summary>
        [JsonRequired]
        [JsonProperty("currency")]
        public CurrencyCode Currency { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MonetaryAmountRequestModel() : base()
        {

        }

        #endregion
    }
}