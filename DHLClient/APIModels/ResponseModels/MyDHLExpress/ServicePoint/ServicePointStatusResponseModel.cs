using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The service point status response
    /// </summary>
    public class ServicePointStatusResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="StatusMessage"/> property
        /// </summary>
        private string? mStatusMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// Status/Error code of the response
        /// </summary>
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Status/error message text of the response
        /// </summary>
        [JsonProperty("statusMessage")]
        public string StatusMessage
        {
            get => mStatusMessage ?? string.Empty;
            set => mStatusMessage = value;
        }

        /// <summary>
        /// Indicates if the response is ok
        /// </summary>
        [JsonProperty("ok")]
        public bool IsOk { get; set; }

        /// <summary>
        /// Indicates the response has warning
        /// </summary>
        [JsonProperty("warning")]
        public bool HasWarning { get; set; }

        /// <summary>
        /// Indicates if the response has error
        /// </summary>
        [JsonProperty("errorStatus")]
        public bool HasErrorStatus { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointStatusResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Status Code: {StatusCode}, Status Message: {StatusMessage}";

        #endregion
    }
}