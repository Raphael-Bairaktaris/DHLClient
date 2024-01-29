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
        public DateOnly Date { get; set; }

        /// <summary>
        /// Please provide the purpose was the document details captured and are planned to be used.
        /// </summary>
        /// <remarks>
        /// export and import is only applicable for approve Sale In Transit customers
        /// </remarks>
        /// <example>import</example>
        [JsonRequired]
        [JsonProperty("function")]
        public FunctionType Function { get; set; }

        /// <summary>
        /// Please provide the customer references at invoice level. 
        /// Note: customerReference/0/value with typeCode 'CU' is mandatory if using POST method and no shipmentTrackingNumber is provided in request. 
        /// It is recommended to provide less than 20 customer references of 'MRN' type code
        /// </summary>
        [JsonProperty("customerReferences")]
        public CustomerReferenceRequestModel? CustomerReferences { get; set; }

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