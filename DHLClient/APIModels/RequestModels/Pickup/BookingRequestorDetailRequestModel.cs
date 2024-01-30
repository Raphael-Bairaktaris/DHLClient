using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating booking requestor details
    /// </summary>
    public class BookingRequestorDetailRequestModel : ShipperDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The contact information
        /// </summary>
        [JsonRequired]
        [JsonProperty("contactInformation")]
        public ContactInformationRequestModel? ContactInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BookingRequestorDetailRequestModel() : base()
        {

        }

        #endregion
    }
}