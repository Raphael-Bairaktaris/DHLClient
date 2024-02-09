using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an additional quantity definition
    /// </summary>
    public class AdditionalQuantityDefinitionRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Item additional quantity value UOM
        /// </summary>
        /// <example>PFL=percent of alcohol</example>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public string? TypeCode { get; set; }

        /// <summary>
        /// An Item's additional quantity value
        /// </summary>
        /// <example>example is percent of alcohol</example>
        [JsonRequired]
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AdditionalQuantityDefinitionRequestModel() : base()
        {

        }

        #endregion
    }
}