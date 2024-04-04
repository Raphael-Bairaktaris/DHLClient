using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration
    /// </summary>
    public class ShipmentDetailExportDeclarationRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter details for each export line item
        /// </summary>
        [JsonRequired]
        [JsonProperty("lineItems")]
        public IEnumerable<ShipmentDetailLineItemRequestModel>? LineItems { get; set; }

        /// <summary>
        /// Please provide invoice related information
        /// </summary>
        [JsonProperty("invoice")]
        public ExportDeclarationInvoiceRequestModel? Invoice { get; set; }

        /// <summary>
        /// Please enter up to three remarks. 
        /// If using Customs Invoice template COMMERCIAL_INVOICE_04, the invoice can only print the first remarks field. The recommended max length is 20 characters. 
        /// If using Customs Invoice template COMMERCIAL_INVOICE_L_10 or COMMERCIAL_INVOICE_P_10, the invoice can print all three remraks fields. 
        /// The recommended max length is 45 characters.
        /// </summary>
        [JsonProperty("remarks")]
        public IEnumerable<ExportDeclarationRemarkRequestModel>? Remarks { get; set; }

        /// <summary>
        /// Please enter additional charge to appear on the invoice.
        /// </summary>
        [JsonProperty("additionalCharges")]
        public IEnumerable<ExportDeclarationAdditionalChargeRequestModel>? AdditionalCharges { get; set; }

        /// <summary>
        /// Please provide destination port details
        /// </summary>
        /// <example>port details</example>
        [JsonProperty("destinationPortName")]
        public string? DestinationPortName { get; set; }

        /// <summary>
        /// Name of port of departure, shipment or destination as required under the applicable delivery term
        /// </summary>
        /// <example>port of departure or destination details</example>
        [JsonProperty("placeOfIncoterm")]
        public string? PlaceOfIncoterm { get; set; }

        /// <summary>
        /// Please provide Payer VAT number
        /// </summary>
        [JsonProperty("payerVATNumber")]
        public string? PayerVATNumber { get; set; }

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
        /// Please provide up to three declaration notes
        /// </summary>
        [JsonProperty("declarationNotes")]
        public IEnumerable<ShipmentDetailExportDeclarationNoteRequestModel>? DeclarationNotes { get; set; }

        /// <summary>
        /// Please enter export reference
        /// </summary>
        [JsonProperty("exportReference")]
        public string? ExportReference { get; set; }

        /// <summary>
        /// Please enter export reason
        /// </summary>
        /// <example>export reason</example>
        [JsonProperty("exportReason")]
        public string? ExportReason { get; set; }

        /// <summary>
        /// Please provide the reason for export
        /// </summary>
        [JsonProperty("exportReasonType")]
        [JsonConverter(typeof(ExportReasonToStringJsonConverter))]
        public ExportReason? ExportReasonType { get; set; }

        /// <summary>
        /// Please provide details about export and import licenses
        /// </summary>
        [JsonProperty("licenses")]
        public IEnumerable<ShipmentDetailExportDeclarationLicenseRequestModel>? Licenses { get; set; }

        /// <summary>
        /// Please provide the shipment was sent for Personal (Gift) or Commercial (Sale) reasons
        /// </summary>
        [JsonProperty("shipmentType")]
        [JsonConverter(typeof(ShipmentPurposeToStringJsonConverter))]
        public ShipmentPurpose? ShipmetType { get; set; }

        /// <summary>
        /// Please provide the Customs Documents at invoice level
        /// </summary>
        [JsonProperty("customsDocuments")]
        public IEnumerable<CustomsDocumentRequestModel>? CustomsDocuments { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailExportDeclarationRequestModel() : base()
        {

        }

        #endregion
    }
}