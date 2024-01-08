using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details routes airport of departure response
    /// </summary>
    public class ShipmentDetailsRoutesAirportOfDepartureResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="LocationName"/> property
        /// </summary>
        private string? mLocationName;

        /// <summary>
        /// The member of the <see cref="LocationCode"/> property
        /// </summary>
        private ShipmentDetailsAirportOfDepartureLocationCodeResponseModel? mLocationCode;

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
        [JsonProperty("LlocationCode")]
        public ShipmentDetailsAirportOfDepartureLocationCodeResponseModel LocationCode 
        { 
            get => mLocationCode ??= new ShipmentDetailsAirportOfDepartureLocationCodeResponseModel();
            set => mLocationCode = value;
        }

        /// <summary>
        /// The super model io schema organization text
        /// </summary>
        [JsonProperty("supermodelIoSchemaorgText")]
        public ShipmentDetailsAirportOfDepartureSuperModelIoSchemaOrganizationTextResponseModel SuperModelIoSchemaOrganizationText { get; set; }

        /// <summary>
        /// The country code
        /// </summary>
        [JsonProperty("countryCode")]
        public CountryCodeType CountryCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsRoutesAirportOfDepartureResponseModel() : base()
        {

        }

        #endregion
    }
}