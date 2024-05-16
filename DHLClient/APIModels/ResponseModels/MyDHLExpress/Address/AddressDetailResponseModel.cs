using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents an address detail 
    /// </summary>
    public class AddressDetailResponseModel
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

        /// <summary>
        /// The member of the <see cref="ServiceArea"/> property
        /// </summary>
        private AddressServiceAreaResponseModel? mServiceArea;

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
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// The service area
        /// </summary>
        [JsonProperty("serviceArea")]
        public AddressServiceAreaResponseModel ServiceArea
        {
            get => mServiceArea ??= new AddressServiceAreaResponseModel();
            set => mServiceArea = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressDetailResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"City Name: {CityName}, :County Name: {CountyName}, Postal Code: {PostalCode}";

        #endregion
    }
}