using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration
    /// </summary>
    public class UploadInvoiceExportDeclarationRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter details for each export line item
        /// </summary>
        [JsonRequired]
        [JsonProperty("lineItems")]
        public IEnumerable<InvoiceLineItemsRequestModel>? LineItems { get; set; }

        /// <summary>
        /// Please provide invoice related information
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoice")]
        public UploadInvoiceDetailRequestModel? Invoice { get; set; }

        /// <summary>
        /// Please enter up to three remarks
        /// </summary>
        [JsonProperty("remark")]
        public IEnumerable<ExportDeclarationRemarkRequestModel>? Remarks { get; set; }

        /// <summary>
        /// Please enter additional charge to appear on the invoice
        /// </summary>
        [JsonProperty("additionalCharges")]
        public IEnumerable<ExportDeclarationAdditionalChargeRequestModel>? AdditionalCharges { get; set; }

        /// <summary>
        /// Name of port of departure, shipment or destination as required under the applicable delivery term.
        /// </summary>
        /// <example>port of departure or destination details</example>
        [JsonProperty("placeOfIncoterm")]
        public string? PlaceOfIncoterm { get; set; }

        /// <summary>
        /// Please enter recipient reference
        /// </summary>
        /// <example>recipient reference</example>
        [JsonProperty("recipientReference")]
        public string? RecipientReference { get; set; }

        /// <summary>
        /// Exporter related details
        /// </summary>
        [JsonProperty("exporter")]
        public ExportDeclarationExporterRequestModel? Exporter { get; set; }

        /// <summary>
        /// Please provide the reason for export
        /// </summary>
        /// <example>permanent</example>
        [JsonProperty("exportReasonType")]
        [JsonConverter(typeof(ExportReasonToStringJsonConverter))]
        public ExportReason? ExportReasonType { get; set; }

        /// <summary>
        /// Please provide the shipment was sent for Personal (Gift) or Commercial (Sale) reasons
        /// </summary>
        /// <example>personal</example>
        [JsonProperty("shipmentType")]
        [JsonConverter(typeof(ShipmentPurposeToStringJsonConverter))]
        public ShipmentPurpose? ShipmentType { get; set; }

        /// <summary>
        /// Please provide the Customs Documents at invoice level
        /// </summary>
        [JsonProperty("customsDocuments")]
        public IEnumerable<CustomsDocumentRequestModel>? CustomsDocuments { get; set; }

        /// <summary>
        /// The Incoterms rules are a globally-recognized set of standards, used worldwide in international and domestic contracts for the delivery of goods, 
        /// illustrating responsibilities between buyer and seller for costs and risk, as well as cargo insurance.
        /// </summary>
        [JsonRequired]
        [JsonProperty("incoterm")]
        [JsonConverter(typeof(IncotermRuleToStringJsonConverter))]
        public IncotermRule Incoterm { get; set; }

        /// <summary>
        /// For customs purposes please advise on currency code of the indicated amount in invoice.
        /// </summary>
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Please enter Unit of measurement - metric,imperial
        /// </summary>
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit UnitOfMeasurement { get; set; }

        /// <summary>
        /// Here you can set invoice properties
        /// </summary>
        [JsonProperty("outputImageProperties")]
        public IEnumerable<InvoiceOutputImagePropertyRequestModel>? OutputImageProperties { get; set; }

        /// <summary>
        /// Here you need to define all the parties needed to ship the package
        /// </summary>
        [JsonProperty("customerDetails")]
        public IEnumerable<ShipmentCustomerDetailLineRequestModel>? CustomerDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadInvoiceExportDeclarationRequestModel() : base()
        {

        }

        #endregion
    }
}