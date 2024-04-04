using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating a line item customer reference
    /// </summary>
    public class LineItemCustomerReferenceRequestModel : BaseCustomerReferenceRequestModel<LineItemReferenceType>
    {
        #region Public Properties

        /// <summary>
        /// Please provide the line item reference type code.
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(LineItemReferenceTypeToStringJsonConverter))]
        public override LineItemReferenceType? TypeCode { get; set; } 

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LineItemCustomerReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}