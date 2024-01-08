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
        private ShipmentDetailsRoutesAirportOfDepartureResponseModel? mAirportOfDeparture;

        /// <summary>
        /// The member of the <see cref="AirportOfDestination"/> property
        /// </summary>
        private ShipmentDetailsRoutesAirportOfDestinationResponseModel? mAirportOfDestination;

        /// <summary>
        /// The member of the <see cref="PlaceOfAcceptance"/> property
        /// </summary>
        private ShipmentDetailsRoutesPlaceOfAcceptanceResponseModel? mPlaceOfAcceptance;

        /// <summary>
        /// The member of the <see cref="PortOfLoading"/> property
        /// </summary>
        private ShipmentDetailsRoutesPortOfLoadingResponseModel? mPortOfLoading;

        /// <summary>
        /// The member of the <see cref="PortOfUnloading"/> property
        /// </summary>
        private ShipmentDetailsRoutesPortOfUnloadingResponseModel? mPortOfUnloading;

        /// <summary>
        /// the member of the <see cref="PlaceOfDelivery"/> property
        /// </summary>
        private ShipmentDetailsRoutesPlaceOfDeliveryResponseModel? mPlaceOfDelivery;

        #endregion

        #region Public Properties

        /// <summary>
        /// The vessel name
        /// </summary>
        [JsonProperty("vesselName")]
        public string VesselName 
        { 
            get => mVesselName ?? string.Empty;
            set => mVesselName = value;
        }

        /// <summary>
        /// The voyage flight number
        /// </summary>
        [JsonProperty("voyageFlightNumber")]
        public string VoyageFlightNumber 
        { 
            get => mVoyageFlightNumber ?? string.Empty;
            set => mVoyageFlightNumber = value;
        }

        /// <summary>
        /// The airport of departure
        /// </summary>
        [JsonProperty("airportOfDeparture")]
        public ShipmentDetailsRoutesAirportOfDepartureResponseModel AirportOfDeparture 
        { 
            get => mAirportOfDeparture ??= new ShipmentDetailsRoutesAirportOfDepartureResponseModel();
            set => mAirportOfDeparture = value;
        }

        /// <summary>
        /// The airport of destination
        /// </summary>
        [JsonProperty("airportOfDestination")]
        public ShipmentDetailsRoutesAirportOfDestinationResponseModel AirportOfDestination 
        { 
            get => mAirportOfDestination ?? new ShipmentDetailsRoutesAirportOfDestinationResponseModel(); 
            set => mAirportOfDestination = value;
        }

        /// <summary>
        /// The estimated departure time
        /// </summary>
        [JsonProperty("estimatedDepartureTime")]
        public DateTime EstimatedDepartureDate { get; set; }

        /// <summary>
        /// The estimated arrival date
        /// </summary>
        [JsonProperty("estimatedArrivalDate")]
        public DateTime EstimatedArrivalDate { get; set; }

        /// <summary>
        /// The place of acceptance
        /// </summary>
        [JsonProperty("placeOfAcceptance")]
        public ShipmentDetailsRoutesPlaceOfAcceptanceResponseModel PlaceOfAcceptance 
        { 
            get => mPlaceOfAcceptance ??= new ShipmentDetailsRoutesPlaceOfAcceptanceResponseModel();
            set => mPlaceOfAcceptance = value;
        }

        /// <summary>
        /// The port of loading
        /// </summary>
        [JsonProperty("portOfLoading")]
        public ShipmentDetailsRoutesPortOfLoadingResponseModel PortOfLoading
        { 
            get => mPortOfLoading ??= new ShipmentDetailsRoutesPortOfLoadingResponseModel();
            set => mPortOfLoading = value;
        }

        /// <summary>
        /// The port of unloading
        /// </summary>
        [JsonProperty("portOfUnloading")]
        public ShipmentDetailsRoutesPortOfUnloadingResponseModel PortOfUnloading 
        { 
            get => mPortOfUnloading ??= new ShipmentDetailsRoutesPortOfUnloadingResponseModel();
            set => mPortOfUnloading = value;
        }

        /// <summary>
        /// The place of delivery
        /// </summary>
        [JsonProperty("placeOfDelivery")]
        public ShipmentDetailsRoutesPlaceOfDeliveryResponseModel PlaceOfDelivery 
        { 
            get => mPlaceOfDelivery ??= new ShipmentDetailsRoutesPlaceOfDeliveryResponseModel();
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
    }
}