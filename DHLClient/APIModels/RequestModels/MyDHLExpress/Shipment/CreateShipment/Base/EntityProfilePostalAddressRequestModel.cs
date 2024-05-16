using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a postal address
    /// </summary>
    public class EntityProfilePostalAddressRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter your postcode or leave empty if the address doesn't have a postcode
        /// </summary>
        /// <example>14800</example>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Please enter the city
        /// </summary>
        /// <example>Prague</example>
        [JsonProperty("cityName")]
        public string? CityName { get; set; }

        /// <summary>
        /// Please enter ISO country code
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Please enter address line 1
        /// </summary>
        /// <example>V Park 2308/10</example>
        [JsonProperty("addressLine1")]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// Please enter address line 2
        /// </summary>
        [JsonProperty("addressLine2")]
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Please enter address line 3
        /// </summary>
        [JsonProperty("addressLine3")]
        public string? AddressLine3 { get; set; }

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
        public string? CountryName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EntityProfilePostalAddressRequestModel() : base()
        {

        }

        #endregion
    }
}