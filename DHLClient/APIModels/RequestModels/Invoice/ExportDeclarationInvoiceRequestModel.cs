using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration invoice
    /// </summary>
    public class ExportDeclarationInvoiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter the commercial invoice number
        /// </summary>
        /// <example>12345-ABC</example>
        [JsonRequired]
        [JsonProperty("number")]
        public string? Number { get; set; }

        /// <summary>
        /// Please enter commercial invoice date
        /// </summary>
        /// <example>2021-03-18</example>
        [JsonRequired]
        [JsonProperty("dare")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly? Date { get; set; }

        /// <summary>
        /// Please enter who has signed the invoice
        /// </summary>
        [JsonProperty("signatureName")]
        public string? SignatureName { get; set; }

        /// <summary>
        /// Please provide title of person who has signed the invoice
        /// </summary>
        [JsonProperty("signatureTitle")]
        public string? SignatureTitle { get; set; }

        /// <summary>
        /// Please provide the signature image
        /// </summary>
        [JsonProperty("signatureImage")]
        public string? SignatureImage { get; set; }

        /// <summary>
        /// Shipment instructions for customs invoice printing purposes. Printed only when using Customs Invoice template COMMERCIAL_INVOICE_04. 
        /// If using Customs Invoice template COMMERCIAL_INVOICE_04, recommended max length is 120 characters.
        /// </summary>
        [JsonProperty("instructions")]
        public IEnumerable<string>? Instructions { get; set; }

        /// <summary>
        /// Customer data text to be printed in customs invoice. Printed only when using Customs, Invoice template, COMMERCIAL_INVOICE_04.
        /// </summary>
        [JsonProperty("customerDataTextEntries")]
        public IEnumerable<string>? CustomerDataTextEntries { get; set; }

        /// <summary>
        /// Please provide the total net weight
        /// </summary>
        [JsonProperty("totalNetWeight")]
        public double? TotalNetWeight { get; set; }

        /// <summary>
        /// Please provide the total gross weight
        /// </summary>
        [JsonProperty("totalGrossWeight")]
        public double? TotalGrossWeight { get; set; }

        /// <summary>
        /// Please provide the customer references at invoice level. 
        /// Note: customerReference/0/value with typeCode 'CU' is mandatory if using POST method and no shipmentTrackingNumber is provided in request. 
        /// It is recommended to provide less than 20 customer references of 'MRN' type code
        /// </summary>
        [JsonProperty("customerReferences")]
        public IEnumerable<CustomerReferenceRequestModel>? CustomerReferences { get; set; }

        /// <summary>
        /// Please provide the terms of payment
        /// </summary>
        /// <example>100 days</example>
        [JsonProperty("termsOfPayment")]
        public string? TermsOfPayment { get; set; }

        /// <summary>
        /// Please provide Perfect Invoice related information
        /// </summary>
        [JsonProperty("indicativeCustomsValues")]
        public IndicativeCustomsValueRequestModel? IndicativeCustomsValues { get; set; }

        /// <summary>
        /// Please provide pre-calculated total values
        /// </summary>
        [JsonProperty("preCalculatedTotalValues")]
        public PreCalculatedTotalValueRequestModel? PreCalculatedTotalValues { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExportDeclarationInvoiceRequestModel() : base()
        {

        }

        #endregion
    }
}