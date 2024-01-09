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
        /// The member of the <see cref="Carrier"/> property
        /// </summary>
        private ShipmentDetailsCarrierResponseModel? mCarrier;

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
        private ShipmentDetailsParticipantResponseModel? mReceiver;

        /// <summary>
        /// The member of the <see cref="Sender"/> property
        /// </summary>
        private ShipmentDetailsParticipantResponseModel? mSender;

        /// <summary>
        /// The member of the <see cref="ProofOfDelivery"/> property
        /// </summary>
        private ShipmentDetailsProofOfDeliveryResponseModel? mProofOfDelivery;

        /// <summary>
        /// The member of the <see cref="PlaceIds"/> property
        /// </summary>
        private IEnumerable<string>? mPlaceIds;

        /// <summary>
        /// The member of the <see cref="Dimensions"/> property
        /// </summary>
        private ShipmentDetailsDimensionsResponseModel? mDimensions;

        /// <summary>
        /// The member of the <see cref="References"/> property
        /// </summary>
        private IEnumerable<ShipmentDetailsReferencesResponseModel>? mReferences;

        /// <summary>
        /// The member of the <see cref="DGFRoutes"/> property
        /// </summary>
        private ShipmentDetailsDGFRoutesResponseModel? mDGFRoutes;

        #endregion

        #region Public Properties

        /// <summary>
        /// The carrier
        /// </summary>
        [JsonProperty("carrier")]
        public ShipmentDetailsCarrierResponseModel? Carrier
        {
            get => mCarrier ?? new ShipmentDetailsCarrierResponseModel();
            set => mCarrier = value;
        }

        /// <summary>
        /// The product
        /// </summary>
        [JsonProperty("product")]
        public ShipmentDetailsProductResponseModel? Product
        {
            get => mProduct ?? new ShipmentDetailsProductResponseModel();
            set => mProduct = value;
        }

        /// <summary>
        /// The destination provider
        /// </summary>
        [JsonProperty("provider")]
        public ShipmentDetailsProviderResponseModel? Provider
        {
            get => mProvider ?? new ShipmentDetailsProviderResponseModel();
            set => mProvider = value;
        }

        /// <summary>
        /// The receiver
        /// </summary>
        [JsonProperty("receiver")]
        public ShipmentDetailsParticipantResponseModel? Receiver
        {
            get => mReceiver ??= new ShipmentDetailsParticipantResponseModel();
            set => mReceiver = value;
        }

        /// <summary>
        /// The sender
        /// </summary>
        [JsonProperty("sender")]
        public ShipmentDetailsParticipantResponseModel? Sender
        {
            get => mSender ??= new ShipmentDetailsParticipantResponseModel();
            set => mSender = value;
        }

        /// <summary>
        /// The proof of delivery
        /// </summary>
        [JsonProperty("proofOfDelivery")]
        public ShipmentDetailsProofOfDeliveryResponseModel? ProofOfDelivery
        {
            get => mProofOfDelivery ??= new ShipmentDetailsProofOfDeliveryResponseModel();
            set => mProofOfDelivery = value;
        }

        /// <summary>
        /// The total number of pieces
        /// </summary>
        [JsonProperty("totalNumberOfPieces")]
        public double TotalNumberOfPieces { get; set; }

        /// <summary>
        /// The place ids
        /// </summary>
        [JsonProperty("placeIds")]
        public IEnumerable<string> PlaceIds
        {
            get => mPlaceIds ?? Enumerable.Empty<string>();
            set => mPlaceIds = value;
        }

        /// <summary>
        /// The weight
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// the volume
        /// </summary>
        [JsonProperty("volume")]
        public double Volume { get; set; }

        /// <summary>
        /// The loading meters
        /// </summary>
        [JsonProperty("loadingMeters")]
        public double LoadingMeters { get; set; }

        /// <summary>
        /// The dimensions
        /// </summary>
        [JsonProperty("dimensions")]
        public ShipmentDetailsDimensionsResponseModel Dimensions
        {
            get => mDimensions ??= new ShipmentDetailsDimensionsResponseModel();
            set => mDimensions = value;
        }

        /// <summary>
        /// The references
        /// </summary>
        [JsonProperty("references")]
        public IEnumerable<ShipmentDetailsReferencesResponseModel> References
        {
            get => mReferences ?? Enumerable.Empty<ShipmentDetailsReferencesResponseModel>();
            set => mReferences = value;
        }

        /// <summary>
        /// The DGF routes
        /// </summary>
        [JsonProperty("routes")]
        public ShipmentDetailsDGFRoutesResponseModel DGFRoutes
        {
            get => mDGFRoutes ??= new ShipmentDetailsDGFRoutesResponseModel();
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
