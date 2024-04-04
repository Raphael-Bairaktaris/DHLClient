using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration additional charge
    /// </summary>
    public class ExportDeclarationAdditionalChargeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide the charge value
        /// </summary>
        /// <example>10</example>
        [JsonProperty("value")]
        public decimal? Value { get; set; }

        /// <summary>
        /// Please enter charge caption
        /// </summary>
        /// <example>fee</example>
        [JsonRequired]
        [JsonProperty("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Please enter charge type
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ChargeTypeToStringJsonConverter))]
        public ChargeType? TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExportDeclarationAdditionalChargeRequestModel() : base()
        {

        }

        #endregion    
    }
}