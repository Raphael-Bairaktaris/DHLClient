using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customs document
    /// </summary>
    public class CustomsDocumentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide the customs documents details
        /// </summary>
        /// <example>972</example>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public CustomsDocumentType TypeCode { get; set; }

        /// <summary>
        /// Please provide the line item customs document ID
        /// </summary>
        /// <example>custdoc445</example>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomsDocumentRequestModel() : base()
        {

        }

        #endregion
    }
}