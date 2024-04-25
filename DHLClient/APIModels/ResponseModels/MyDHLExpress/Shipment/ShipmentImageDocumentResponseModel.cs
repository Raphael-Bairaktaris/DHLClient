using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment image documents
    /// </summary>
    public class ShipmentImageDocumentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        /// <summary>
        /// The member of the <see cref="EncodingFormat"/> property
        /// </summary>
        private string? mEncodingFormat;

        /// <summary>
        /// The member of the <see cref="Content"/> property
        /// </summary>
        private string? mContent;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipment tracking number
        /// </summary>
        /// <example>1234567890</example>
        [JsonProperty("shipmentTrackingNumber")]
        public long ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// Identifies type of the document like commercial invoice or waybill, or archived zip documents
        /// </summary>
        /// <example>waybill</example>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        /// <summary>
        /// Clearance code or document function whether for import, export or both. Returned only for customs-entry
        /// </summary>
        /// <example>import</example>
        [JsonProperty("function")]
        [JsonConverter(typeof(FunctionTypeToStringJsonConverter))]
        public FunctionType Function { get; set; }

        /// <summary>
        /// Identifies image format the document is created in, like PDF, TIFF, or ZIP
        /// </summary>
        /// <example>PDF</example>
        [JsonProperty("encodingFormat")]
        public string EncodingFormat
        {
            get => mEncodingFormat ?? string.Empty;
            set => mEncodingFormat = value;
        }

        /// <summary>
        /// Contains base64 encoded document image or archived zip
        /// </summary>
        [JsonProperty("content")]
        public string Content
        {
            get => mContent ?? string.Empty;
            set => mContent = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentImageDocumentResponseModel() : base()
        {

        }

        #endregion
    }
}