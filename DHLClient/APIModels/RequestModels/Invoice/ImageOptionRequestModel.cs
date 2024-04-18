using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an image option
    /// </summary>
    public class ImageOptionRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter the document type you want to wish set properties for
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(InvoiceToStringJsonConverter))]
        public Invoice? TypeCode { get; set; }

        /// <summary>
        /// Please enter DHL Express document template name.
        /// </summary>
        /// <example>COMMERCIAL_INVOICE_P_10</example>
        [JsonProperty("templateName")]
        public string? TemplateName { get; set; }

        /// <summary>
        /// If set to true then the document is rendered otherwise not
        /// </summary>
        [JsonProperty("isRequested")]
        public bool? IsRequested { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ImageOptionRequestModel() : base()
        {

        }

        #endregion
    }
}