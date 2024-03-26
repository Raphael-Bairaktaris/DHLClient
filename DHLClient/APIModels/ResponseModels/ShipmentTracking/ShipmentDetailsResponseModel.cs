using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represent a shipment detail response
    /// </summary>
    public class ShipmentDetailsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Product"/> property
        /// </summary>
        private ShipmentDetailsProductResponseModel? mProduct;

        /// <summary>
        /// The member of the <see cref="Provider"/> property
        /// </summary>
        private ShipmentDetailsProviderResponseModel? mProvider;

        /// <summary>
        /// The member of the <see cref="Receiver"/> property
        /// </summary>
        private ShipmentDetailsEntityResponseModel? mReceiver;

        /// <summary>
        /// The member of the <see cref="Sender"/> property
        /// </summary>
        private ShipmentDetailsEntityResponseModel? mSender;

        /// <summary>
        /// The member of the <see cref="Carrier"/> property
        /// </summary>
        private ShipmentDetailsEntityResponseModel? mCarrier;

        /// <summary>
        /// The member of the <see cref="ProofOfDelivery"/> property
        /// </summary>
        private ShipmentDetailsProofOfDeliveryResponseModel? mProofOfDelivery;

        /// <summary>
        /// The member of the <see cref="PlaceIds"/> property
        /// </summary>
        private IEnumerable<string>? mPlaceIds;

        /// <summary>
        /// The member of the <see cref="Weight"/> property
        /// </summary>
        private ShipmentDetailQuantityResponseModel? mWeight;

        /// <summary>
        /// The member of the <see cref="Volume"/> property
        /// </summary>
        private ShipmentDetailQuantityResponseModel? mVolume;

        /// <summary>
        /// The member of the <see cref="Dimensions"/> property
        /// </summary>
        private ShipmentDetailDimensionResponseModel? mDimensions;

        /// <summary>
        /// The member of the <see cref="References"/> property
        /// </summary>
        private IEnumerable<ShipmentDetailsReferencesResponseModel>? mReferences;

        /// <summary>
        /// The member of the <see cref="ValueAddedServices"/> property
        /// </summary>
        private IEnumerable<ShipmentDetailValueAddedServicesResponseModel>? mValueAddedServices;

        /// <summary>
        /// The member of the <see cref="ControlledDataCodes"/> property
        /// </summary>
        private IEnumerable<string>? mControlledDataCodes;

        /// <summary>
        /// The member of the <see cref="DGFRoutes"/> property
        /// </summary>
        private IEnumerable<ShipmentDetailsDGFRoutesResponseModel>? mDGFRoutes;

        #endregion

        #region Public Properties

        /// <summary>
        /// Offered product or service
        /// </summary>
        [JsonProperty("product")]
        public ShipmentDetailsProductResponseModel? Product
        {
            get => mProduct ?? new ShipmentDetailsProductResponseModel();
            set => mProduct = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer
        /// </summary>
        [JsonProperty("provider")]
        public ShipmentDetailsProviderResponseModel? Provider
        {
            get => mProvider ?? new ShipmentDetailsProviderResponseModel();
            set => mProvider = value;
        }

        /// <summary>
        /// A real organization or personal entity, if type is not specified, a Organization implementation is used
        /// </summary>
        [JsonProperty("receiver")]
        public ShipmentDetailsEntityResponseModel? Receiver
        {
            get => mReceiver ??= new ShipmentDetailsEntityResponseModel();
            set => mReceiver = value;
        }

        /// <summary>
        /// A real organization or personal entity, if type is not specified, a Organization implementation is used
        /// </summary>
        [JsonProperty("sender")]
        public ShipmentDetailsEntityResponseModel? Sender
        {
            get => mSender ??= new ShipmentDetailsEntityResponseModel();
            set => mSender = value;
        }

        /// <summary>
        /// A real organization or personal entity, if type is not specified, a Organization implementation is used
        /// </summary>
        [JsonProperty("carrier")]
        public ShipmentDetailsEntityResponseModel? Carrier
        {
            get => mCarrier ?? new ShipmentDetailsEntityResponseModel();
            set => mCarrier = value;
        }

        /// <summary>
        /// An acknowledgment that an order successfully arrived at its intended destination
        /// </summary>
        [JsonProperty("proofOfDelivery")]
        public ShipmentDetailsProofOfDeliveryResponseModel? ProofOfDelivery
        {
            get => mProofOfDelivery ??= new ShipmentDetailsProofOfDeliveryResponseModel();
            set => mProofOfDelivery = value;
        }

        /// <summary>
        /// \'Yes\' if signer identification is available
        /// </summary>
        [JsonProperty("proofOfDeliverySignedAvailable")]
        public bool? IsProofOfDeliverySignedAvailable { get; set; }

        /// <summary>
        /// Total number of items or pieces in the shipment
        /// </summary>
        [JsonProperty("totalNumberOfPieces")]
        public double? TotalNumberOfPieces { get; set; }

        /// <summary>
        /// Ids of all the items or pieces in the shipment
        /// </summary>
        [JsonProperty("placeIds")]
        public IEnumerable<string> PlaceIds
        {
            get => mPlaceIds ?? Enumerable.Empty<string>();
            set => mPlaceIds = value;
        }

        /// <summary>
        /// A point value or interval for product characteristics and other purposes
        /// </summary>
        [JsonProperty("weight")]
        public ShipmentDetailQuantityResponseModel Weight
        {
            get => mWeight ?? new ShipmentDetailQuantityResponseModel();
            set => mWeight = value;
        }

        /// <summary>
        /// A point value or interval for product characteristics and other purposes
        /// </summary>
        [JsonProperty("volume")]
        public ShipmentDetailQuantityResponseModel Volume
        {
            get => mVolume ?? new ShipmentDetailQuantityResponseModel();
            set => mVolume = value;
        }

        /// <summary>
        /// A loading meter standard unit of measurement for transport by truck
        /// </summary>
        [JsonProperty("loadingMeters")]
        public double LoadingMeters { get; set; }

        /// <summary>
        /// A measurable extent of a particular kind of delivery
        /// </summary>
        [JsonProperty("dimensions")]
        public ShipmentDetailDimensionResponseModel Dimensions
        {
            get => mDimensions ??= new ShipmentDetailDimensionResponseModel();
            set => mDimensions = value;
        }

        /// <summary>
        /// A list of indications that refers to related shipment
        /// </summary>
        [JsonProperty("references")]
        public IEnumerable<ShipmentDetailsReferencesResponseModel> References
        {
            get => mReferences ?? Enumerable.Empty<ShipmentDetailsReferencesResponseModel>();
            set => mReferences = value;
        }

        /// <summary>
        /// Services I booked together with my Tracking details
        /// </summary>
        [JsonProperty("valueAddedServices")]
        public IEnumerable<ShipmentDetailValueAddedServicesResponseModel> ValueAddedServices
        {
            get => mValueAddedServices ?? Enumerable.Empty<ShipmentDetailValueAddedServicesResponseModel>();
            set => mValueAddedServices = value;
        }

        /// <summary>
        /// Extra Controlled Access Data Codes
        /// </summary>
        [JsonProperty("controlledDataCodes")]
        public IEnumerable<string> ControlledDataCodes
        {
            get => mControlledDataCodes ?? Enumerable.Empty<string>();
            set => mControlledDataCodes = value;
        }

        /// <summary>
        /// DHL Global Forwarding routing Details
        /// </summary>
        [JsonProperty("routes")]
        public IEnumerable<ShipmentDetailsDGFRoutesResponseModel> DGFRoutes
        {
            get => mDGFRoutes ??= Enumerable.Empty<ShipmentDetailsDGFRoutesResponseModel>();
            set => mDGFRoutes = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsResponseModel() : base()
        {

        }

        #endregion
    }
}
