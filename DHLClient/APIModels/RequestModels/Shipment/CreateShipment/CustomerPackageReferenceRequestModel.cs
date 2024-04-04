using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating a customer package reference
    /// </summary>
    public class CustomerPackageReferenceRequestModel : BaseCustomerReferenceRequestModel<CustomerReference>
    {
        #region Public Properties

        /// <summary>
        /// Please provide the customer reference type
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(CustomerReferenceToStringJsonConverter))]
        public override CustomerReference? TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerPackageReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}