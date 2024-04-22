using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a package 
    /// </summary>
    public class PackageResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TrackingNumber"/> property
        /// </summary>
        private string? mTrackingNumber { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// Piece serial number
        /// </summary>
        /// <example>1</example>
        [JsonProperty("referenceNumber")]
        public int ReferenceNumber { get; set; }

        /// <summary>
        /// Here is provided each piece its Identification number
        /// </summary>
        /// <example>JD914600003889482921</example>
        [JsonRequired]
        [JsonProperty("trackingNumber")]
        public string TrackingNumber 
        { 
            get => mTrackingNumber ?? string.Empty;
            set => mTrackingNumber = value;
        }

        /// <summary>
        /// You can use this URL to track your shipment by Piece Identification Number
        /// </summary>
        /// <example>https://express.api.dhl.com/mydhlapi/shipments/1234567890/tracking?PieceID=JD014600003889482921</example>
        [JsonProperty("trackingUrl")]
        public Uri? TrackingURL { get; set; }

        /// <summary>
        /// Here is provided each piece volumetric/ dimensional weight
        /// </summary>
        /// <example>2.5</example>
        [JsonProperty("volumetricWeight")]
        public double VolumetricWeight { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PackageResponseModel() : base()
        {

        }

        #endregion
    }
}