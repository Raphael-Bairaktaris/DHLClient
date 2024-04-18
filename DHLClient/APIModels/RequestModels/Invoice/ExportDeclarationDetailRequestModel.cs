using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration
    /// </summary>
    public class ExportDeclarationDetailRequestModel
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
        [JsonProperty("invoice")]
        public ExportDeclarationInvoiceRequestModel? Invoice { get; set; }

        /// <summary>
        /// Please enter up to three remarks
        /// </summary>
        [JsonProperty("remarks")]
        public IEnumerable<ExportDeclarationRemarkRequestModel>? Remarks { get; set; }

        /// <summary>
        /// Please enter additional charge to appear on the invoice
        /// </summary>
        [JsonProperty("additionalCharges")]
        public IEnumerable<ExportDeclarationAdditionalChargeRequestModel>? AdditionalCharges { get; set; }

        /// <summary>
        /// Name of port of departure, shipment or destination as required under the applicable delivery term.
        /// </summary>
        [JsonProperty("placeOfIncoterm")]
        public string? PlaceOfIncoterm { get; set; }

        /// <summary>
        /// Please enter the recipient's reference
        /// </summary>
        [JsonProperty("recipientReference")]
        public string? Recipientreference { get; set; }

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
        /// The Incoterms rules are a globally-recognized set of standards, used worldwide in international and domestic 
        /// contracts for the delivery of goods, illustrating responsibilities between buyer and seller for costs and risk, as well as cargo insurance.
        /// </summary>
        /// <example>DAP</example>
        [JsonRequired]
        [JsonProperty("incoterm")]
        [JsonConverter(typeof(IncotermRuleToStringJsonConverter))]
        public IncotermRule? Incoterm { get; set; }

        /// <summary>
        /// For customs purposes please advise on currency code of the indicated amount in invoice.
        /// </summary>
        /// <example>EUR</example>
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? Currency { get; set; }

        /// <summary>
        /// Please enter Unit of measurement
        /// </summary>
        /// <example>metric</example>
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit? UnitOfMeasurement { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExportDeclarationDetailRequestModel() : base()
        {

        }

        #endregion
    }
}