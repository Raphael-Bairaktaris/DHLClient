using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an image option
    /// </summary>
    public class ImageOptionRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter the document type you want to wish set properties for
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(DeliveryDocumentTypeToStringJsonConverter))]
        public DeliveryDocumentType TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ImageOptionRequestModel() : base()
        {

        }

        #endregion
    }
}