using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating an invoice customer reference
    /// </summary>
    public class InvoiceCustomerReferenceRequestModel : BaseCustomerReferenceRequestModel<InvoiceCustomerReference>
    {
        #region Public Properties

        /// <summary>
        /// Please provide the customer references at invoice level. 
        /// It is recommended to provide less than 20 customer references of 'MRN' type code.
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(InvoiceCustomerReferenceToStringJsonConverter))]
        public override InvoiceCustomerReference? TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceCustomerReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}