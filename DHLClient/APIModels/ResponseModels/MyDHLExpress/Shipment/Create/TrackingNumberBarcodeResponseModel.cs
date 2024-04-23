using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a tracking number barcode
    /// </summary>
    public class TrackingNumberBarcodeResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TrackingNumberBarcodeContent"/> property
        /// </summary>
        private string? mTrackingNumberBarcodeContent;

        #endregion

        #region Public Properties

        /// <summary>
        /// Piece serial number
        /// </summary>
        [JsonProperty("referenceNumber")]
        public int ReferenceNumber { get; set; }

        /// <summary>
        /// Barcode base4 image of each piece of the shipment
        /// </summary>
        [JsonProperty("trackingNumberBarcodeContent")]
        public string TrackingNumberBarcodeContent
        {
            get => mTrackingNumberBarcodeContent ?? string.Empty;
            set => mTrackingNumberBarcodeContent = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackingNumberBarcodeResponseModel() : base()
        {

        }

        #endregion
    }
}