using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an upload commercial invoice response
    /// </summary>
    public class UploadCommercialInvoiceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        #endregion

        #region Public Properties

        /// <summary>
        /// The warnings
        /// </summary>
        /// <example>some values provided may be invalid</example>
        [JsonProperty("warnings")]
        public IEnumerable<string> Warnings
        {
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        /// <summary>
        /// The status
        /// </summary>
        /// <example>OK</example>
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
        public UploadCommercialInvoiceResponseModel() : base()
        {

        }

        #endregion
    }
}
