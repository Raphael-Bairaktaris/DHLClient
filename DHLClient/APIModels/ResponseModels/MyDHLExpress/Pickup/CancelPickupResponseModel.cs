using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a pickup cancellation
    /// </summary>
    public class CancelPickupResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Instance"/> property
        /// </summary>
        private string? mInstance;

        /// <summary>
        /// The member of the <see cref="Detail"/> property
        /// </summary>
        private string? mDetail;

        /// <summary>
        /// The member of the <see cref="Title"/> property
        /// </summary>
        private string? mTitle;

        /// <summary>
        /// The member of the <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        /// <summary>
        /// The member of the <see cref="AdditionalDetails"/> property
        /// </summary>
        private IEnumerable<string>? mAdditionalDetails;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        #endregion

        #region Public Properties

        /// <summary>
        /// The instance
        /// </summary>
        [JsonProperty("instance")]
        public string Instance
        {
            get => mInstance ?? string.Empty;
            set => mInstance = value;
        }

        /// <summary>
        /// The detail
        /// </summary>
        [JsonProperty("detail")]
        public string Detail
        {
            get => mDetail ?? string.Empty;
            set => mDetail = value;
        }

        /// <summary>
        /// The title
        /// </summary>
        [JsonProperty("title")]
        public string Title
        {
            get => mTitle ?? string.Empty;
            set => mTitle = value;
        }

        /// <summary>
        /// The message
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get => mMessage ?? string.Empty;
            set => mMessage = value;
        }

        /// <summary>
        /// The additional details
        /// </summary>
        [JsonProperty("additionalDetails")]
        public IEnumerable<string> AdditionalDetails
        {
            get => mAdditionalDetails ?? Enumerable.Empty<string>();
            set => mAdditionalDetails = value;
        }

        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;
            set => mStatus = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelPickupResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Instance: {Instance}, Detail: {Detail}, Title: {Title}, Message: {Message}, Status: {Status}";

        #endregion
    }
}
