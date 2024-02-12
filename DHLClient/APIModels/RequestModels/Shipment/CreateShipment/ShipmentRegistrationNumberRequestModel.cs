using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a registration number
    /// </summary>
    public class ShipmentRegistrationNumberRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The tax identifier type
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public TaxIdentifier? TypeCode { get; set; }

        /// <summary>
        /// Please enter registration number
        /// </summary>
        /// <example>CZ123456789</example>
        [JsonRequired]
        [JsonProperty("number")]
        public string? RegistrationNumber { get; set; }

        /// <summary>
        /// Please enter 2 character code of the country where the Registration Number has been issued by
        /// </summary>
        [JsonRequired]
        [JsonProperty("issuerCountryCode")]
        public CountryCode? IssuerCountryCode { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentRegistrationNumberRequestModel() : base()
        {

        }

        #endregion
    }
}