using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer reference
    /// </summary>
    public class CustomerReferenceRequestModel : BaseCustomerReferenceRequestModel<CustomerReference>
    {
        #region Public Properties

        /// <summary>
        /// Please provide the line item reference type code.
        /// </summary>
        /// <example>AFE</example>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(LineItemReferenceTypeToStringJsonConverter))]
        public override LineItemReferenceType? TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}