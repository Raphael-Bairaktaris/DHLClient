using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail address response
    /// </summary>
    public class ServicePointDetailAddressResponseModel
    {
        #region Private Members

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
        /// The member of the <see cref="Street"/> property
        /// </summary>
        private string? mStreet;

        /// <summary>
        /// The member of the <see cref="AdditionalInfo"/> property
        /// </summary>
        private string? mAdditionalInfo;

        /// <summary>
        /// The member of the <see cref="City"/> property
        /// </summary>
        private string? mCity;

        /// <summary>
        /// The member of the <see cref="ZipCode"/> property
        /// </summary>
        private string? mZipCode;

        /// <summary>
        /// The member of the <see cref="State"/> property
        /// </summary>
        private string? mState;

        /// <summary>
        /// The member of the <see cref="CountryDivisionCode"/> property
        /// </summary>
        private string? mCountryDivisionCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// First line of the facility address
        /// </summary>
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
        /// Street details in facility address
        /// </summary>
        [JsonProperty("street")]
        public string Street
        {
            get => mStreet ?? string.Empty;
            set => mStreet = value;
        }

        /// <summary>
        /// House number in facility address
        /// </summary>
        [JsonProperty("houseNumber")]
        public double HouseNumber { get; set; }

        /// <summary>
        /// Additional details in facility address
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo
        {
            get => mAdditionalInfo ?? string.Empty;
            set => mAdditionalInfo = value;
        }

        /// <summary>
        /// Facility city
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get => mCity ?? string.Empty;
            set => mCity = value;
        }

        /// <summary>
        /// Zip code of the facility
        /// </summary>
        [JsonProperty("zipCode")]
        public string ZipCode
        {
            get => mZipCode ?? string.Empty;
            set => mZipCode = value;
        }

        /// <summary>
        /// State
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get => mState ?? string.Empty;
            set => mState = value;
        }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("country")]
        public CountryCode Country { get; set; }

        /// <summary>
        /// DHL country
        /// </summary>
        [JsonProperty("dhlCountry")]
        public CountryCode DHLCountry { get; set; }

        /// <summary>
        /// Country Division Code
        /// </summary>
        [JsonProperty("countryDivisionCode")]
        public string CountryDivisionCode
        {
            get => mCountryDivisionCode ?? string.Empty;
            set => mCountryDivisionCode = value;
        }

        /// <summary>
        /// Enumeration (State, Province)
        /// </summary>
        [JsonProperty("countryDivisionCodeType")]
        public CountryDivisionCode CountryDivisionCodeType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailAddressResponseModel() : base()
        {

        }

        #endregion
    }
}