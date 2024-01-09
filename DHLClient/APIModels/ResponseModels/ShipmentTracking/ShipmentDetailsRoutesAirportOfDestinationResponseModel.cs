using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details routes airport of destination response
    /// </summary>
    public class ShipmentDetailsRoutesAirportOfDestinationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="LocationName"/> property
        /// </summary>
        private string? mLocationName;

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
        public ShipmentDetailsAirportOfDestinationLocationCodeResponseModel? LocationCode { get; set; }

        /// <summary>
        /// The country code
        /// </summary>
        public ShipmentDetailsAirportOfDestinationCountryCodeResponseModel? CountryCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsRoutesAirportOfDestinationResponseModel() : base()
        {

        }

        #endregion
    }
}