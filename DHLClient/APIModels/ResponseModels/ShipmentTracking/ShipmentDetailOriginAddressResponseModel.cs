using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment origin address response
    /// </summary>
    public class ShipmentDetailOriginAddressResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="AddressLocality"/> property
        /// </summary>
        private string? mAddressLocality;

        /// <summary>
        /// The member of the <see cref="AddressLocalityServicing"/> property
        /// </summary>
        private string? mAddressLocalityServicing;

        /// <summary>
        /// The member of the <see cref="AddressRegion"/> property 
        /// </summary>
        private string? mAddressRegion;

        /// <summary>
        /// The member of the <see cref="PostalCode"/> property
        /// </summary>
        private string? mPostalCode;

        /// <summary>
        /// The member of the <see cref="StreetAddress"/> property
        /// </summary>
        private string? mStreetAddress;

        #endregion

        #region Public Properties

        /// <summary>
        /// Text specifying the name of the locality, for example a city
        /// </summary>
        /// <example>Prague</example>
        [JsonProperty("addressLocality")]
        public string AddressLocality
        {
            get => mAddressLocality ?? string.Empty;
            set => mAddressLocality = value;
        }

        /// <summary>
        /// Text specifying a detail of address locality
        /// </summary>
        /// <example>Chodov</example>
        [JsonProperty("addressLocalityServicing")]
        public string AddressLocalityServicing
        {
            get => mAddressLocalityServicing ?? string.Empty;
            set => mAddressLocalityServicing = value;
        }

        /// <summary>
        /// Text specifying a detail of country
        /// </summary>
        /// <example>Prague 11</example>
        [JsonProperty("addressRegion")]
        public string AddressRegion
        {
            get => mAddressRegion ?? string.Empty;
            set => mAddressRegion = value;
        }

        /// <summary>
        /// Code specifying the country for the address using ISO 3166-1
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// Text specifying the postal code for an address
        /// </summary>
        /// <example>14000</example>
        [JsonProperty("postalCode")]
        public string PostalCode
        {
            get => mPostalCode ?? string.Empty;
            set => mPostalCode = value;
        }

        /// <summary>
        /// The street address expressed as free form text
        /// </summary>
        /// <example>Batman Avenue 1040</example>
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
        public ShipmentDetailOriginAddressResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Address Locality: {AddressLocality}, Address Region: {AddressRegion}. Postal Code: {PostalCode}, Street Address: {StreetAddress}";

        #endregion
    }
}
