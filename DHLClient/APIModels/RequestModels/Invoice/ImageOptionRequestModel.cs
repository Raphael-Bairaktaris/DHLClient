using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an image option
    /// </summary>
    public class ImageOptionsRequestModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="EncodingFormat"/> property
        /// </summary>
        private EncodingFormat? mEncodingFormat;

        #endregion

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

        /// <summary>
        /// To be used for waybillDoc. If set to true then account information will not be printed on the waybillDoc
        /// </summary>
        [JsonProperty("hideAccountNumber")]
        public bool? ShouldHideAccountNumber { get; set; }

        /// <summary>
        /// You can ask up to 2 waybillDoc copies to be provided
        /// </summary>
        [JsonProperty("numberOfCopies")]
        public int? NumberOfCopies { get; set; }

        /// <summary>
        /// Please advise what type of customs documentation is required
        /// </summary>
        [JsonProperty("invoiceType")]
        [JsonConverter(typeof(InvoiceTypeToStringJsonConverter))]
        public InvoiceType? InvoiceType { get; set; }

        /// <summary>
        /// Please enter ISO 3 letters language code for invoice or shipment receipt
        /// </summary>
        /// <example>eng</example>
        [JsonProperty("languageCode")]
        [JsonConverter(typeof(ThreeLetterLanguageCodeToStringJsonConverter))]
        public ThreeLetterLanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// Please enter ISO 2 letters language country code for invoice or shipment receipt
        /// </summary>
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToLowerStringJsonConverter))]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Please enter ISO 4 letters language script code for shipment receipt
        /// </summary>
        /// <example>Latn</example>
        [JsonProperty("languageScriptCode")]
        [JsonConverter(typeof(FourLetterLanguageScriptToStringJsonConverter))]
        public FourLetterLanguageScript? LanguageScriptCode { get; set; }

        /// <summary>
        /// Please provide the format of the QR Code output format.
        /// </summary>
        [JsonProperty("encodingFormat")]
        public EncodingFormat? EncodingFormat
        {
            get { return mEncodingFormat; }
            set
            {
                if (value == DHLClient.EncodingFormat.PDF)
                    mEncodingFormat = value;
                else
                    throw new ArgumentException("Invalid encoding format. Only PDF is allowed");
            }
        }

        /// <summary>
        /// DHL Logo to be printed in Transport Label or Waybill Document
        /// </summary>
        [JsonProperty("renderDHLLogo")]
        public bool? ShouldRenderDHLLogo { get; set; }

        /// <summary>
        /// To print respective Transport Label and Waybill document into A4 margin PDF
        /// </summary>
        [JsonProperty("fitLabelsToA4")]
        public bool? ShouldFitLabelsToA4 { get; set; }

        /// <summary>
        /// Additional customer label free text that can be printed in certain label.
        /// </summary>
        [JsonProperty("labelFreeText")]
        public string? LabelFreeText { get; set; }

        /// <summary>
        /// Additional customer label text that can be printed in certain label
        /// </summary>
        [JsonProperty("labelCustomerDataText")]
        public string? LabelCustomerDataText { get; set; }

        /// <summary>
        /// Declaration text that can be printed in certain shipment receipt template
        /// </summary>
        [JsonProperty("shipmentReceiptCustomerDataText")]
        public string? ShipmentReceiptCustomerDataText { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ImageOptionsRequestModel() : base()
        {

        }

        #endregion
    }
}