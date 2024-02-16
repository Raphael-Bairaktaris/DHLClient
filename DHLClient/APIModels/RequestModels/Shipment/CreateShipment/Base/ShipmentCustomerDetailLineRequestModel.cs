using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipper detail
    /// </summary>
    public class ShipmentCustomerDetailLineRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The postal address
        /// </summary>
        [JsonProperty("postalAddress")]
        public ShipmentCustomerDetailPostalAddressRequestModel? PostalAddress { get; set; }

        /// <summary>
        /// The contact information
        /// </summary>
        [JsonProperty("contactInformation")]
        public ShipmentCustomerDetailContactInformationRequestModel? ContactInformation { get; set; }

        /// <summary>
        /// The registration numbers
        /// </summary>
        [JsonProperty("registrationNumbers")]
        public IEnumerable<ShipmentRegistrationNumberRequestModel>? RegistrationNumbers { get; set; }

        /// <summary>
        /// The bank details
        /// </summary>
        [JsonProperty("bankDetails")]
        public IEnumerable<ShipmentCustomerBankDetailRequestModel>? BankDetails { get; set; }

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
        public ShipmentCustomerDetailLineRequestModel() : base()
        {

        }

        #endregion
    }
}