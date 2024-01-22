using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a cancel pickup response
    /// </summary>
    public class CancelPickupResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The instance
        /// </summary>
        [JsonProperty("instance")]
        public string Instance { get; set; }

        /// <summary>
        /// The detail
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// The title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The additional details
        /// </summary>
        [JsonProperty("additionalDetails")]
        public IEnumerable<string> AdditionalDetails { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelPickupResponseModel() : base()
        {

        }

        #endregion
    }
}
