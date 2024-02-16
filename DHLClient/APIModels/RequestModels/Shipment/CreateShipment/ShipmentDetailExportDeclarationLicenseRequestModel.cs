using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an export declaration license
    /// </summary>
    public class ShipmentDetailExportDeclarationLicenseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide type of the license
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(FunctionTypeToStringJsonConverter))]
        public FunctionType? TypeCode { get; set; }

        /// <summary>
        /// Please provide the license
        /// </summary>
        /// <example>license</example>
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailExportDeclarationLicenseRequestModel() : base()
        {

        }

        #endregion
    }
}