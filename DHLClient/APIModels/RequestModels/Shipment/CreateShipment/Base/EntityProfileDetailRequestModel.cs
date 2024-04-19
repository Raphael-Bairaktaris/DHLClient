using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipper detail
    /// </summary>
    public class EntityProfileDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The postal address
        /// </summary>
        [JsonProperty("postalAddress")]
        public EntityProfilePostalAddressRequestModel? PostalAddress { get; set; }

        /// <summary>
        /// The contact information
        /// </summary>
        [JsonProperty("contactInformation")]
        public EntityProfileContactInformationRequestModel? ContactInformation { get; set; }

        /// <summary>
        /// The registration numbers
        /// </summary>
        [JsonProperty("registrationNumbers")]
        public IEnumerable<EntityProfileRegistrationNumberRequestModel>? RegistrationNumbers { get; set; }

        /// <summary>
        /// The bank details
        /// </summary>
        [JsonProperty("bankDetails")]
        public IEnumerable<EntityProfileBankDetailRequestModel>? BankDetails { get; set; }

        /// <summary>
        /// Please enter the business party role type of the shipper
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(BusinessPartyToStringJsonConverter))]
        public BusinessPartyType TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EntityProfileDetailRequestModel() : base()
        {

        }

        #endregion
    }
}