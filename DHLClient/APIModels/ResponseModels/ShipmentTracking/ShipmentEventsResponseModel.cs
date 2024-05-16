using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a shipment event response
    /// </summary>
    public class ShipmentEventsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="PlaceIds"/> property
        /// </summary>
        private IEnumerable<string>? mPlaceIds;

        /// <summary>
        /// The member of the <see cref="Remark"/> property
        /// </summary>
        private string? mRemark;

        /// <summary>
        /// The member of the <see cref="NextSteps"/> property
        /// </summary>
        private IEnumerable<string>? mNextSteps;

        #endregion

        #region Public Properties

        /// <summary>
        /// A combination of date and time of day
        /// </summary>
        [JsonProperty("timestamp")]
        //[JsonConverter(typeof(DateTimeOffsetToUnixTimestampJsonConverter))]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The location of object
        /// </summary>
        [JsonProperty("location")]
        public ShipmentEventsLocationResponseModel? Location { get; set; }

        /// <summary>
        /// Code of the status (high-level grouping statuses)
        /// </summary>
        [JsonProperty("statusCode")]
        [JsonConverter(typeof(StatusCodeTypeToStringJsonConverter))]
        public StatusCodeType StatusCode { get; set; }

        /// <summary>
        /// Short description of the status - title
        /// </summary>
        /// <example> Customs inspection. </example>
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;
            set => mStatus = value;
        }

        /// <summary>
        /// Human-readable detailed description
        /// </summary>
        /// <example> Package delivered. </example>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The remark
        /// </summary>
        /// <example> The shipment is pending completion of customs inspection. </example>
        [JsonProperty("remark")]
        public string Remark
        {
            get => mRemark ?? string.Empty;
            set => mRemark = value;
        }

        /// <summary>
        /// The next steps
        /// </summary>
        /// <example> The status will be updated following customs inspection. </example>
        [JsonProperty("nextSteps")]
        public IEnumerable<string> NextSteps
        {
            get => mNextSteps ?? Enumerable.Empty<string>();
            set => mNextSteps = value;
        }

        /// <summary>
        /// Ids of all the items or pieces in the shipment
        /// </summary>
        [JsonProperty("placeIds")]
        public IEnumerable<string> PlaceIds
        {
            get => mPlaceIds ?? Enumerable.Empty<string>();
            set => mPlaceIds = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentEventsResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Timestamp {Timestamp}, Status Code: {StatusCode}, Remark: {Remark}";

        #endregion
    }
}
