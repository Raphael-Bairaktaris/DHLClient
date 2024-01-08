using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details proof of delivery response
    /// </summary>
    public class ShipmentDetailsProofOfDeliveryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="SignatureURL"/> property
        /// </summary>
        private string? mSignatureURL;

        /// <summary>
        /// The member of the <see cref="DocumentURL"/> property
        /// </summary>
        private string? mDocumentURL;

        #endregion

        #region Public Properties

        /// <summary>
        /// The timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The signature URL
        /// </summary>
        [JsonProperty("signatureUrl")]
        public string SignatureURL 
        { 
            get => mSignatureURL ?? string.Empty;
            set => mSignatureURL = value;
        }

        /// <summary>
        /// The document URL
        /// </summary>
        [JsonProperty("documentUrl")]
        public string DocumentURL 
        { 
            get => mDocumentURL ?? string.Empty;
            set => mDocumentURL = value;
        }

        /// <summary>
        /// The signed
        /// </summary>
        [JsonProperty("signed")]
        public ShipmentDetailsSignedResponseModel? Signed { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsProofOfDeliveryResponseModel() : base()
        {

        }

        #endregion
    }
}