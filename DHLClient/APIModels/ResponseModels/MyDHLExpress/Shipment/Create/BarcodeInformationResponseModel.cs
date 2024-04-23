using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents barcode information
    /// </summary>
    public class BarcodeInformationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ShipmentIdentificationNumberBarcodeContent"/> property
        /// </summary>
        private string? mShipmentIdentificationNumberBarcodeContent;

        /// <summary>
        /// The member of the <see cref="OriginDestinationServiceTypeBarcodeContent"/> property
        /// </summary>
        private string? mOriginDestinationServiceTypeBarcodeContent;

        /// <summary>
        /// The member of the <see cref="RoutingBarcodeContent"/> property
        /// </summary>
        private string? mRoutingBarcodeContent;

        /// <summary>
        /// The member of the <see cref="TrackingNumberBarcodes"/> property
        /// </summary>
        private TrackingNumberBarcodeResponseModel? mTrackingNumberBarcodes;

        #endregion

        #region Public Properties

        /// <summary>
        /// Barcode base64 encoded airway bill number
        /// </summary>
        [JsonProperty("shipmentIdentificationNumberBarcodeContent")]
        public string ShipmentIdentificationNumberBarcodeContent
        {
            get => mShipmentIdentificationNumberBarcodeContent ?? string.Empty;
            set => mShipmentIdentificationNumberBarcodeContent = value;
        }

        /// <summary>
        /// Barcode base64 image of origin service area code, destination service area code and global product code
        /// </summary>
        [JsonProperty("originDestinationServiceTypeBarcodeContent")]
        public string OriginDestinationServiceTypeBarcodeContent
        {
            get => mOriginDestinationServiceTypeBarcodeContent ?? string.Empty;
            set => mOriginDestinationServiceTypeBarcodeContent = value;
        }

        /// <summary>
        /// Barcode base64 image of DHL routing code
        /// </summary>
        [JsonProperty("routingBarcodeContent")]
        public string RoutingBarcodeContent
        {
            get => mRoutingBarcodeContent ?? string.Empty;
            set => mRoutingBarcodeContent = value;
        }

        /// <summary>
        /// Here you can find barcode details for each piece
        /// </summary>
        [JsonProperty("trackingNumberBarcodes")]
        public TrackingNumberBarcodeResponseModel TrackingNumberBarcodes
        {
            get => mTrackingNumberBarcodes ??= new TrackingNumberBarcodeResponseModel();
            set => mTrackingNumberBarcodes = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BarcodeInformationResponseModel() : base()
        {

        }

        #endregion
    }
}