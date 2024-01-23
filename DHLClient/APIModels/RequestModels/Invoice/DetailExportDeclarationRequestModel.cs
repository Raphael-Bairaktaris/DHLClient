using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration
    /// </summary>
    public class DetailExportDeclarationRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter details for each export line item
        /// </summary>
        [JsonRequired]
        [JsonProperty("lineItems")]
        public InvoiceLineItemsRequestModel? LineItems { get; set; }

        /// <summary>
        /// Please provide invoice related information
        /// </summary>
        [JsonProperty("invoice")]
        public ExportDeclarationInvoiceRequestModel? Invoice { get;set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailExportDeclarationRequestModel() : base()
        {

        }

        #endregion
    }
}