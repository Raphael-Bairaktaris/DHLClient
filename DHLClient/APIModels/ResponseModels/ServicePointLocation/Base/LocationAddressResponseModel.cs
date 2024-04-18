using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a location by address response
    /// </summary>
    public class LocationAddressResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PostalCode"/> property
        /// </summary>
        private string? mPostalCode;

        /// <summary>
        /// the member of the <see cref="AddressLocality"/> property
        /// </summary>
        private string? mAddressLocality;

        /// <summary>
        /// The member of the <see cref="StreetAddress"/> property
        /// </summary>
        private string? mStreetAddress;

        #endregion

        #region Public Properties

        /// <summary>
        /// A short text string code (ISO 3166-1 alpha-2 country code) specifying the country.
        /// </summary>
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// Text specifying the postal code for an address.
        /// </summary>
        /// <remarks> https://gs1.org/voc/postalCode </remarks>
        [JsonProperty("postalCode")]
        public string PostalCode
        {
            get => mPostalCode ?? string.Empty;
            set => mPostalCode = value;
        }

        /// <summary>
        /// Text specifying the name of the locality, for example a city.
        /// </summary>
        /// <remarks> https://gs1.org/voc/addressLocality </remarks>
        [JsonProperty("addressLocality")]
        public string AddressLocality
        {
            get => mAddressLocality ?? string.Empty;
            set => mAddressLocality = value;
        }

        /// <summary>
        /// The street address expressed as free form text. The street address is 
        /// printed on paper as the first lines below the name. For example, the name of the street and the number in the street or the name of a building.
        /// </summary>
        [JsonProperty("streetAddress")]
        public string StreetAddress
        {
            get => mStreetAddress ?? string.Empty;
            set => mStreetAddress = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationAddressResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Postal Code: {PostalCode}, Street Address: {StreetAddress}";

        #endregion
    }
}
