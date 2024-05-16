using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer reference
    /// </summary>
    public class ShipmentCustomerReferenceRequestModel : BaseCustomerReferenceRequestModel<CustomerReference>
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
        public ShipmentCustomerReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}