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
        [JsonRequired]
        [JsonProperty("typeCode")]
        public CustomsDocumentType TypeCode { get; set; }

        /// <summary>
        /// Please provide the line item customs document ID
        /// </summary>
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