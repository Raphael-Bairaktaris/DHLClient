using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details DGF routes response
    /// </summary>
    public class ShipmentDetailsDGFRoutesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="VesselName"/> property
        /// </summary>
        private string? mVesselName;

        /// <summary>
        /// The member of the <see cref="VoyageFlightNumber"/> property
        /// </summary>
        private string? mVoyageFlightNumber;

        /// <summary>
        /// The member of the <see cref="AirportOfDeparture"/> property
        /// </summary>
        private ShipmentDetailsRoutesAirportResponseModel? mAirportOfDeparture;

        /// <summary>
        /// The member of the <see cref="AirportOfDestination"/> property
        /// </summary>
        private ShipmentDetailsRoutesAirportResponseModel? mAirportOfDestination;

        /// <summary>
        /// The member of the <see cref="PlaceOfAcceptance"/> property
        /// </summary>
        private ShipmentDetailsShippingRouteLocationResponseModel? mPlaceOfAcceptance;

        /// <summary>
        /// The member of the <see cref="PortOfLoading"/> property
        /// </summary>
        private ShipmentDetailsShippingRouteLocationResponseModel? mPortOfLoading;

        /// <summary>
        /// The member of the <see cref="PortOfUnloading"/> property
        /// </summary>
        private ShipmentDetailsShippingRouteLocationResponseModel? mPortOfUnloading;

        /// <summary>
        /// the member of the <see cref="PlaceOfDelivery"/> property
        /// </summary>
        private ShipmentDetailsShippingRouteLocationResponseModel? mPlaceOfDelivery;

        #endregion

        #region Public Properties

        /// <summary>
        /// Vessel Name for Ocean
        /// </summary>
        /// <example>MAERSK SARAT</example>
        [JsonProperty("dgf:vesselName")]
        public string VesselName
        {
            get => mVesselName ?? string.Empty;
            set => mVesselName = value;
        }

        /// <summary>
        /// Voyage number for Ocean, Flight Carrier and Value for Air
        /// </summary>
        /// <example>TR TRUCK</example>
        [JsonProperty("dgf:voyageFlightNumber")]
        public string VoyageFlightNumber
        {
            get => mVoyageFlightNumber ?? string.Empty;
            set => mVoyageFlightNumber = value;
        }

        /// <summary>
        /// DHL Global Forwarding Airport
        /// </summary>
        [JsonProperty("dgf:airportOfDeparture")]
        public ShipmentDetailsRoutesAirportResponseModel AirportOfDeparture
        {
            get => mAirportOfDeparture ??= new ShipmentDetailsRoutesAirportResponseModel();
            set => mAirportOfDeparture = value;
        }

        /// <summary>
        /// DHL Global Forwarding Airport
        /// </summary>
        [JsonProperty("airportOfDestination")]
        public ShipmentDetailsRoutesAirportResponseModel AirportOfDestination
        {
            get => mAirportOfDestination ?? new ShipmentDetailsRoutesAirportResponseModel();
            set => mAirportOfDestination = value;
        }

        /// <summary>
        /// Flight Estimated Date and Time of Departure
        /// </summary>
        [JsonProperty("estimatedDepartureTime")]
        public DateTime EstimatedDepartureDate { get; set; }

        /// <summary>
        /// Flight Estimated Date and Time of Arrival
        /// </summary>
        [JsonProperty("estimatedArrivalDate")]
        public DateTime EstimatedArrivalDate { get; set; }

        /// <summary>
        /// DHL Global Forwarding Location
        /// </summary>
        [JsonProperty("placeOfAcceptance")]
        public ShipmentDetailsShippingRouteLocationResponseModel PlaceOfAcceptance
        {
            get => mPlaceOfAcceptance ??= new ShipmentDetailsShippingRouteLocationResponseModel();
            set => mPlaceOfAcceptance = value;
        }

        /// <summary>
        /// DHL Global Forwarding Location
        /// </summary>
        [JsonProperty("portOfLoading")]
        public ShipmentDetailsShippingRouteLocationResponseModel PortOfLoading
        {
            get => mPortOfLoading ??= new ShipmentDetailsShippingRouteLocationResponseModel();
            set => mPortOfLoading = value;
        }

        /// <summary>
        /// DHL Global Forwarding Location
        /// </summary>
        [JsonProperty("portOfUnloading")]
        public ShipmentDetailsShippingRouteLocationResponseModel PortOfUnloading
        {
            get => mPortOfUnloading ??= new ShipmentDetailsShippingRouteLocationResponseModel();
            set => mPortOfUnloading = value;
        }

        /// <summary>
        /// DHL Global Forwarding Location
        /// </summary>
        [JsonProperty("placeOfDelivery")]
        public ShipmentDetailsShippingRouteLocationResponseModel PlaceOfDelivery
        {
            get => mPlaceOfDelivery ??= new ShipmentDetailsShippingRouteLocationResponseModel();
            set => mPlaceOfDelivery = value;
        }

        #endregion 

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsDGFRoutesResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Vessel Name: {VesselName}, Voyage Flight Value: {VoyageFlightNumber}, Estimated Departure Date: {EstimatedDepartureDate}, Estimated Arrival Date: {EstimatedArrivalDate}";

        #endregion
    }
}