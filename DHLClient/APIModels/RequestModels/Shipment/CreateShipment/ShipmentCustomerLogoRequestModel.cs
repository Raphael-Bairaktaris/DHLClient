using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer logo
    /// </summary>
    public class ShipmentCustomerLogoRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please specify image file format
        /// </summary>
        [JsonRequired]
        [JsonProperty("fileFormat")]
        [JsonConverter(typeof(FileFormatToStringJsonConverter))]
        public FileFormat? FileFormat { get; set; }

        /// <summary>
        /// Please provide base64 encoded logo image
        /// </summary>
        [JsonRequired]
        [JsonProperty("content")]
        public string? Content { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentCustomerLogoRequestModel() : base()
        {

        }

        #endregion
    }
}