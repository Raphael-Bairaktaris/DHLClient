using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represent shipper details request
    /// </summary>
    public class ShipperDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter your postcode or leave empty if the address doesn't have a postcode
        /// </summary>
        /// <example>14800</example>
        [JsonRequired]
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Please enter the city
        /// </summary>
        /// <example>Prague</example>
        [JsonRequired]
        [JsonProperty("cityName")]
        public string? CityName { get; set; }

        /// <summary>
        /// Please enter ISO country code
        /// </summary>
        /// <example>CZ</example>
        [JsonRequired]
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Please enter your province or state code
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("provinceCode")]
        public string? ProvinceCode { get; set; }

        /// <summary>
        /// Please enter address line 1
        /// </summary>
        /// <example>V Park 2308/10</example>
        [JsonRequired]
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
        /// Please enter your suburb or county name
        /// </summary>
        /// <example>Central Bohemia</example>
        [JsonProperty("countyName")]
        public string? CountyName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipperDetailRequestModel() : base()
        {

        }

        #endregion
    }
}