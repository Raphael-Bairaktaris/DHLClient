using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a postal address
    /// </summary>
    public class PostalAddressResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PostalCode"/> property
        /// </summary>
        private string? mPostalCode;

        /// <summary>
        /// The member of the <see cref="CityName"/> property
        /// </summary>
        private string? mCityName;

        /// <summary>
        /// The member of the <see cref="ProvinceCode"/> property
        /// </summary>
        private string? mProvinceCode;

        /// <summary>
        /// The member of the <see cref="AddressLine1"/> property
        /// </summary>
        private string? mAddressLine1;

        /// <summary>
        /// The member of the <see cref="AddressLine2"/> property
        /// </summary>
        private string? mAddressLine2;

        /// <summary>
        /// The member of the <see cref="AddressLine3"/> property
        /// </summary>
        private string? mAddressLine3;

        /// <summary>
        /// The member of the <see cref="CityDistrictName"/> property
        /// </summary>
        private string? mCityDistrictName;

        /// <summary>
        /// The member of the <see cref="ProvinceName"/> property
        /// </summary>
        private string? mProvinceName;

        /// <summary>
        /// The member of the <see cref="CountryName"/> property
        /// </summary>
        private string? mCountryName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The postal code 
        /// </summary>
        /// <example>27801</example>
        [JsonProperty("postalCode")]
        public string PostalCode
        {
            get => mPostalCode ?? string.Empty;
            set => mPostalCode = value;
        }

        /// <summary>
        /// The city name
        /// </summary>
        /// <example>Kralupy nad Vltavou</example>
        [JsonProperty("cityName")]
        public string CityName
        {
            get => mCityName ?? string.Empty;
            set => mCityName = value;
        }

        /// <summary>
        /// The country code
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// Province or state code
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("provinceCode")]
        public string ProvinceCode
        {
            get => mProvinceCode ?? string.Empty;
            set => mProvinceCode = value;
        }

        /// <summary>
        /// First line of the facility address
        /// </summary>
        /// <example>Na Cukrovaku 1063</example>
        [JsonProperty("addressLine1")]
        public string AddressLine1
        {
            get => mAddressLine1 ?? string.Empty;
            set => mAddressLine1 = value;
        }

        /// <summary>
        /// Second line of the facility address (only present if field is filled in GREF database)
        /// </summary>
        [JsonProperty("addressLine2")]
        public string AddressLine2
        {
            get => mAddressLine2 ?? string.Empty;
            set => mAddressLine2 = value;
        }

        /// <summary>
        /// Third line of the facility address (only present if field is filled in GREF database)
        /// </summary>
        [JsonProperty("addressLine3")]
        public string AddressLine3
        {
            get => mAddressLine3 ?? string.Empty;
            set => mAddressLine3 = value;
        }

        /// <summary>
        /// Suburb or county name
        /// </summary>
        /// <example>Kralupy</example>
        [JsonProperty("cityDistrictName")]
        public string CityDistrictName
        {
            get => mCityDistrictName ?? string.Empty;
            set => mCityDistrictName = value;
        }

        /// <summary>
        /// Please enter your state or province name
        /// </summary>
        /// <example>Central Bohemia</example>
        [JsonProperty("provinceName")]
        public string ProvinceName
        {
            get => mProvinceName ?? string.Empty;
            set => mProvinceName = value;
        }

        /// <summary>
        /// Please enter your country name
        /// </summary>
        /// <example>Czech Republic</example>
        [JsonProperty("countryName")]
        public string CountryName
        {
            get => mCountryName ?? string.Empty;
            set => mCountryName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PostalAddressResponseModel() : base()
        {

        }

        #endregion
    }
}