using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment creation
    /// </summary>
    public class CreateShipmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Packages"/> property
        /// </summary>
        private IEnumerable<PackageResponseModel>? mPackages;

        /// <summary>
        /// The member of the <see cref="Documents"/> property
        /// </summary>
        private IEnumerable<DocumentResponseModel>? mDocuments;

        /// <summary>
        /// The member of the <see cref="ShipmentDetails"/> property
        /// </summary>
        private IEnumerable<CreateShipmentDetailResponseModel>? mShipmentDetails;

        /// <summary>
        /// The member of the <see cref="ShipmentCharges"/> property
        /// </summary>
        private IEnumerable<ShipmentChargeResponseModel>? mShipmentCharges;

        /// <summary>
        /// The member of the <see cref="BarcodeInfo"/> property
        /// </summary>
        private BarcodeInformationResponseModel? mBarcodeInfo;

        /// <summary>
        /// The member of the <see cref="EstimatedDeliveryDate"/> property
        /// </summary>
        private EstimatedDeliveryDateResponseModel? mEstimatedDeliveryDate;

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        #endregion

        #region Public Properties

        /// <summary>
        /// URL where the request has been sent to
        /// </summary>
        [JsonProperty("url")]
        public Uri? URL { get; set; }

        /// <summary>
        /// Here you will receive Shipment Identification Number of your package
        /// </summary>
        [JsonProperty("shipmentTrackingNumber")]
        public long ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// If you requested pickup for your shipment you can use this URL to cancel the pickup
        /// </summary>
        [JsonProperty("cancelPickupUrl")]
        public Uri? CancelPickupURL { get; set; }

        /// <summary>
        /// You can use this URL to track your shipment
        /// </summary>
        [JsonProperty("trackingUrl")]
        public Uri? TrackingURL { get; set; }

        /// <summary>
        /// If you asked for pickup service here you will find Dispatch Confirmation Number which identifies your pickup booking
        /// </summary>
        [JsonProperty("dispatchConfirmationNumber")]
        public string? DispatchConfirmationNumber { get; set; }

        /// <summary>
        /// Here you can find information for all pieces your shipment is having like Piece Identification Number
        /// </summary>
        [JsonProperty("packages")]
        public IEnumerable<PackageResponseModel> Packages
        {
            get => mPackages ?? Enumerable.Empty<PackageResponseModel>();
            set => mPackages = value;
        }

        /// <summary>
        /// Here you can find all documents created for the shipment like Transport and WaybillDoc labels, Invoice, Receipt
        /// </summary>
        [JsonProperty("documents")]
        public IEnumerable<DocumentResponseModel> Documents
        {
            get => mDocuments ?? Enumerable.Empty<DocumentResponseModel>();
            set => mDocuments = value;
        }

        /// <summary>
        /// In this field you will find the On Demand Delivery (ODD) URL link if requested
        /// </summary>
        /// <example>https://odd-test.dhl.com/odd-online/US/wH24aaaaa1</example>
        [JsonProperty("onDemandDeliveryURL")]
        public Uri? OnDemandDelivery { get; set; }

        /// <summary>
        /// Here you can find additional information related to your shipment when you ask for it in the request
        /// </summary>
        [JsonProperty("shipmentDetails")]
        public IEnumerable<CreateShipmentDetailResponseModel> ShipmentDetails
        {
            get => mShipmentDetails ?? Enumerable.Empty<CreateShipmentDetailResponseModel>();
            set => mShipmentDetails = value;
        }

        /// <summary>
        /// Here you can find rates related to your shipment
        /// </summary>
        [JsonProperty("shipmentCharges")]
        public IEnumerable<ShipmentChargeResponseModel> ShipmentCharges
        {
            get => mShipmentCharges ?? Enumerable.Empty<ShipmentChargeResponseModel>();
            set => mShipmentCharges = value;
        }

        /// <summary>
        /// Here you can find barcode details in base64
        /// </summary>
        [JsonProperty("barcodeInfo")]
        public BarcodeInformationResponseModel BarcodeInfo
        {
            get => mBarcodeInfo ??= new BarcodeInformationResponseModel();
            set => mBarcodeInfo = value;
        }

        /// <summary>
        ///Here you can find details of estimated delivery date
        /// </summary>
        [JsonProperty("estimatedDeliveryDate")]
        public EstimatedDeliveryDateResponseModel EstimatedDeliveryDate
        {
            get => mEstimatedDeliveryDate ??= new EstimatedDeliveryDateResponseModel();
            set => mEstimatedDeliveryDate = value;
        }

        /// <summary>
        /// The warnings
        /// </summary>
        /// <example>Can't return prices</example>
        [JsonProperty("warnings")]
        public IEnumerable<string> Warnings
        {
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateShipmentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Shipment Tracking Number: {ShipmentTrackingNumber}, Dispatch Confirmation Number: {DispatchConfirmationNumber}, Warnings: {Warnings}";

        #endregion
    }
}
