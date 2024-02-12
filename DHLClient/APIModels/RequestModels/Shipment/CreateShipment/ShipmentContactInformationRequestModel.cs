using Newtonsoft.Json;


namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating contact information
    /// </summary>
    public class ShipmentContactInformationRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter the email address
        /// </summary>
        /// <example>that@before.de</example>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Please enter phone number
        /// </summary>
        /// <example>+1123456789</example>
        [JsonRequired]
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Please enter mobile phone number
        /// </summary>
        /// <example>+60112345678</example>
        [JsonProperty("mobilePhone")]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// Please enter company name
        /// </summary>
        [JsonRequired]
        [JsonProperty("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Please enter full name
        /// </summary>
        /// <example>John Brew</example>
        [JsonRequired]
        [JsonProperty("fullName")]
        public string? FullName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentContactInformationRequestModel() : base()
        {

        }

        #endregion
    }
}