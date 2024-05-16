using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a registration number
    /// </summary>
    public class EntityProfileRegistrationNumberRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The tax identifier type
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(TaxIdentifierToStringJsonConverter))]
        public TaxIdentifier? TaxIdentifier { get; set; }

        /// <summary>
        /// Please enter registration number
        /// </summary>
        /// <example>CZ123456789</example>
        [JsonRequired]
        [JsonProperty("number")]
        public string? RegistrationNumber { get; set; }

        /// <summary>
        /// Please enter 2 character code of the country where the Registration Value has been issued by
        /// </summary>
        /// <example>CZ</example>
        [JsonRequired]
        [JsonProperty("issuerCountryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode? IssuerCountryCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EntityProfileRegistrationNumberRequestModel() : base()
        {

        }

        #endregion
    }
}