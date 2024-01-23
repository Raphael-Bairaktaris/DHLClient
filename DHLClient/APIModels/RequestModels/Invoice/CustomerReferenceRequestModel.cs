using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer reference
    /// </summary>
    public class CustomerReferenceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide the line item reference type code.
        /// </summary>
        /// <example>AFE</example>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public LineItemReferenceType TypeCode { get; set; }

        /// <summary>
        /// Please provide the line item reference
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

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