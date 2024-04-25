using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a document
    /// </summary>
    public class DocumentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Content"/> property
        /// </summary>
        private string? mContent;

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Identifies image format the document is created in, like PDF, JPG etc.
        /// </summary>
        [JsonProperty("imageFormat")]
        [JsonConverter(typeof(ImageFormatToStringJsonConverter))]
        public ImageFormat ImageFormat { get; set; }

        /// <summary>
        /// Contains base64 encoded document image
        /// </summary>
        [JsonProperty("content")]
        public string Content
        {
            get => mContent ?? string.Empty;
            set => mContent = value;
        }

        /// <summary>
        /// Identifies type of the document, like invoice, label or receipt
        /// </summary>
        /// <example>label</example>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        /// <summary>
        /// The package reference number
        /// </summary>
        [JsonProperty("packageReferenceNumber")]
        public int PackageReferenceNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DocumentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Content: {Content}, TypeCode: {TypeCode}";

        #endregion
    }
}