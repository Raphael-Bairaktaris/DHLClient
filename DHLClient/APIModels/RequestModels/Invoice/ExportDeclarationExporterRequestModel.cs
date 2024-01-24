using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an exporter
    /// </summary>
    public class ExportDeclarationExporterRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide exporter id
        /// </summary>
        /// <example>123</example>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Please provide exporter code
        /// </summary>
        /// <example>EXPCZ</example>
        [JsonProperty("code")]
        public string? Code { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExportDeclarationExporterRequestModel() : base()
        {

        }

        #endregion
    }
}