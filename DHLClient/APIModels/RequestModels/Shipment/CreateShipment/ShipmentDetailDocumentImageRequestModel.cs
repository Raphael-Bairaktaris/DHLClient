using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a document image
    /// </summary>
    public class ShipmentDetailDocumentImageRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide correct document type you wish to upload
        /// </summary>
        /// <example>INV</example>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(DocumentTypeToStringJsonConverter))]
        public DocumentType? TypeCode { get; set; }

        /// <summary>
        /// Please provide the image file format for the document you want to upload
        /// </summary>
        /// <example>PDF</example>
        [JsonProperty("imageFormat")]
        [JsonConverter(typeof(ImageFormatToStringJsonConverter))]
        public ImageFormat? ImageFormat { get; set; }

        /// <summary>
        /// Please provide the base64 encoded document
        /// </summary>
        [JsonRequired]
        [JsonProperty("content")]
        public string? Content { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailDocumentImageRequestModel() : base()
        {

        }

        #endregion
    }
}