using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represent receiver details request
    /// </summary>
    public class ReceiverDetailsRequestModel : ShipperDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The contact information
        /// </summary>
        [JsonProperty("contactInformation")]
        public ShipmentContactInformationRequestModel? ContactInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReceiverDetailsRequestModel() : base()
        {

        }

        #endregion
    }
}