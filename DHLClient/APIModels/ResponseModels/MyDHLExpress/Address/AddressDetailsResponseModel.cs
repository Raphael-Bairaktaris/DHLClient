using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an address detail response
    /// </summary>
    public class AddressDetailsResponseModel : ShipmentOccurrenceServiceAreaResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="CityName"/> property
        /// </summary>
        private string? mCityName;

        /// <summary>
        /// The member of the <see cref="CountyName"/> property
        /// </summary>
        private string? mCountyName;

        /// <summary>
        /// The member of the <see cref="PostalCode"/> property
        /// </summary>
        private string? mPostalCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The city name
        /// </summary>
        [JsonProperty("cityName")]
        public string CityName
        {
            get => mCityName ?? string.Empty;
            set => mCityName = value;
        }

        /// <summary>
        /// The county name
        /// </summary>
        /// <example>Moravia</example>
        [JsonProperty("countyName")]
        public string CountyName
        {
            get => mCountyName ?? string.Empty;
            set => mCountyName = value;
        }

        /// <summary>
        /// The postal code 
        /// </summary>
        /// <example>55500</example>
        [JsonProperty("postalCode")]
        public string PostalCode
        {
            get => mPostalCode ?? string.Empty;
            set => mPostalCode = value;
        }

        /// <summary>
        /// The country code
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("countryCode")]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// The time offset
        /// </summary>
        [JsonProperty("GMTOffset")]
        public string? GMTOffset { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressDetailsResponseModel() : base()
        {

        }

        #endregion
    }
}