using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// RRequests used for creating or updating a trade entity detail
    /// </summary>
    public class TradeEntityDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The postal address details
        /// </summary>
        [JsonRequired]
        [JsonProperty("postalAddress")]
        public ShipperDetailRequestModel? PostalAddress { get; set; }

        /// <summary>
        /// The contact information
        /// </summary>
        [JsonRequired]
        [JsonProperty("contactInformation")]
        public ContactInformationRequestModel? ContactInformation { get; set; }

        /// <summary>
        /// The business party type
        /// </summary>
        /// <example>business</example>
        [JsonProperty("typeCode")]
        public BusinessPartyType? TypeCode { get; set; }

        /// <summary>
        /// The registration number details
        /// </summary>
        [JsonProperty("registrationNumbers")]
        public RegistrationNumberRequestModel? RegistrationNumbers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TradeEntityDetailRequestModel() : base()
        {

        }

        #endregion
    }
}