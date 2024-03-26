using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an upload paperless trade shipment
    /// </summary>
    public class UploadPaperLessTradeShipmentResponseModel
    {
        #region Public properties

        /// <summary>
        /// Unique identifier of the transaction
        /// </summary>
        [JsonProperty("invocationId")]
        public string? InvocationId { get; set; }

        /// <summary>
        /// Message reference provided by customer as part of request or automatically generated when not provided
        /// </summary>
        [JsonProperty("messageReference")]
        public string? MessageReference { get; set; }

        /// <summary>
        /// The content language
        /// </summary>
        public LanguageCode? ContentLanguage { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadPaperLessTradeShipmentResponseModel() : base()
        {

        }

        #endregion
    }
}
