using Newtonsoft.Json;

namespace DHLClient
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
        /// The event location
        /// </summary>
        [JsonProperty("location")]
        public ShipmentEventsLocationResponseModel? Location { get; set; }

        /// <summary>
        /// The status code
        /// </summary>
        [JsonProperty("statusCode")]
        public StatusCodeType StatusCode { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        /// <example> Customs inspection. </example>
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;
            set => mStatus = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        /// <example> Package delivered. </example>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// the place ids
        /// </summary>
        [JsonProperty("placeIds")]
        public IEnumerable<string> PlaceIds
        {
            get => mPlaceIds ?? Enumerable.Empty<string>();
            set => mPlaceIds = value;
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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentEventsResponseModel() : base()
        {

        }

        #endregion
    }
}
