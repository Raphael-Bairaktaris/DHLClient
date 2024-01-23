using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration remark
    /// </summary>
    public class ExportDeclarationRemarkRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter remark text
        /// </summary>
        /// <example>declaration remark</example>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExportDeclarationRemarkRequestModel() : base()
        {

        }

        #endregion
    }
}