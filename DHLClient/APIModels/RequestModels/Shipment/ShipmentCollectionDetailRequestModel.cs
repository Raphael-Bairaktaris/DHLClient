using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating pickup details
    /// </summary>
    public class ShipmentCollectionDetailRequestModel : ShipperDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter your state or province name
        /// </summary>
        /// <example>Central Bohemia</example>
        [JsonProperty("provinceName")]
        public string? ProvinceName { get; set; }

        /// <summary>
        /// Please enter your country name
        /// </summary>
        /// <example>Czech Republic</example>
        [JsonProperty("countryName")]
        public CountryCode? CountryName { get; set; }

        /// <summary>
        /// The contact information
        /// </summary>
        [JsonRequired]
        [JsonProperty("contactInformation")]
        public ContactInformationRequestModel? ContactInformation { get; set; }

        /// <summary>
        /// The registration numbers
        /// </summary>
        [JsonProperty("registrationNumbers")]
        public RegistrationNumberRequestModel? RegistrationNumbers { get; set; }

        /// <summary>
        /// The bank details
        /// </summary>
        [JsonRequired]
        [JsonProperty("bankDetails")]
        public BankDetailRequestModel? BankDetails { get; set; }

        /// <summary>
        /// Please enter the business party type related to the pickup.
        /// </summary>
        [JsonProperty("typeCode")]
        public BusinessPartyType? TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentCollectionDetailRequestModel() : base()
        {

        }

        #endregion
    }
}