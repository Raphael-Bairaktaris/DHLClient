using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represent a shipment status response
    /// </summary>
    public class ShipmentStatusResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Timestamp"/> property
        /// </summary>
        private string? mTimestamp;

        /// <summary>
        /// The member of the <see cref="Location"/> property
        /// </summary>
        private ShipmentDetailOriginResponseModel? mLocation;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="Remark"/> property
        /// </summary>
        private string? mRemark;

        /// <summary>
        /// The member of the <see cref="NextSteps"/>
        /// </summary>
        private IEnumerable<string>? mNextSteps;

        #endregion

        #region Public Properties

        /// <summary>
        /// The time stamp
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp
        {
            get => mTimestamp ?? string.Empty;
            set => mTimestamp = value;
        }

        /// <summary>
        /// The location
        /// </summary>
        [JsonProperty("location")]
        public ShipmentDetailOriginResponseModel Location
        {
            get => mLocation ??= new ShipmentDetailOriginResponseModel();
            set => mLocation = value;
        }

        /// <summary>
        /// Code of the status (high-level grouping statuses)
        /// </summary>
        /// <example>delivered</example>
        [JsonProperty("statusCode")]
        [JsonConverter(typeof(StatusCodeTypeToStringJsonConverter))]
        public StatusCodeType? StatusCode { get; set; }

        /// <summary>
        /// Short description of the status - title
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;
            set => mStatus = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// Remark regarding the shipment status
        /// </summary>
        /// <example> The shipment is pending completion of customs inspection. </example>
        [JsonProperty("remark")]
        public string Remark
        {
            get => mRemark ?? string.Empty;
            set => mRemark = value;
        }

        /// <summary>
        /// Description of the next steps
        /// </summary>
        [JsonProperty("nextSteps")]
        public IEnumerable<string> NextSteps
        {
            get => mNextSteps ?? Enumerable.Empty<string>();
            set => mNextSteps = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentStatusResponseModel() : base()
        {

        }

        #endregion
    }
}
