using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating goods characteristic
    /// </summary>
    public class GoodsCharacteristicRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Item additional quantity value 
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public string? TypeCode { get; set; }

        /// <summary>
        /// An Item's additional quantity value
        /// </summary>
        [JsonRequired]
        [JsonProperty("amount")]
        public double Amount { get; set; }

        

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GoodsCharacteristicRequestModel() : base()
        {

        }

        #endregion

    }
}