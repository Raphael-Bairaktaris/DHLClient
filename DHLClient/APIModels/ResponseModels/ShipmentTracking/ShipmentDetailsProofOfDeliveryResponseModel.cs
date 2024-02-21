using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details proof of delivery response
    /// </summary>
    public class ShipmentDetailsProofOfDeliveryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Signed"/> property
        /// </summary>
        private ShipmentDetailsEntityResponseModel? mSigned;

        #endregion

        #region Public Properties

        /// <summary>
        /// The document URL
        /// </summary>
        /// <remarks>https://webpod.dhl.com/pod?token=510f1359603a768a57af49cf10083f90&language=en</remarks>
        [JsonProperty("documentUrl")]
        public Uri? DocumentURL { get; set; }

        /// <summary>
        /// The signature URL
        /// </summary>
        [JsonProperty("signatureUrl")]
        public Uri? SignatureURL { get; set; }

        /// <summary>
        /// A real organization or personal entity, if type is not specified, a Organization implementation is used
        /// </summary>
        [JsonProperty("signed")]
        public ShipmentDetailsEntityResponseModel Signed 
        { 
            get => mSigned ??= new ShipmentDetailsEntityResponseModel();
            set => mSigned = value;
        }

        /// <summary>
        /// Date and time of related proof of delivery document
        /// </summary>
        /// <example>2022-10-21T12:30:00</example>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimeStampJsonConverter))]
        public DateTimeOffset? Timestamp { get; set; }

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