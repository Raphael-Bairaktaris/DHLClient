using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details routes airport of departure response
    /// </summary>
    public class ShipmentDetailsRoutesAirportResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="LocationName"/> property
        /// </summary>
        private string? mLocationName;

        /// <summary>
        /// The member of the <see cref="LocationCode"/> property
        /// </summary>
        private string? mLocationCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The location name
        /// </summary>
        [JsonProperty("locationName")]
        public string LocationName
        {
            get => mLocationName ?? string.Empty;
            set => mLocationName = value;
        }

        /// <summary>
        /// The location code
        /// </summary>
        [JsonProperty("locationCode")]
        public string LocationCode
        {
            get => mLocationCode ??= string.Empty;
            set => mLocationCode = value;
        }

        /// <summary>
        /// Airport of departure/destination ISO country code
        /// </summary>
        [JsonProperty("countryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode CountryCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsRoutesAirportResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Location Name: {LocationName}, Location Code {LocationCode}";

        #endregion
    }
}