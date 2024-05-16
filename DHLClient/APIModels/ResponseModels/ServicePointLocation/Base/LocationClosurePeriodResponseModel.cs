using Newtonsoft.Json;

namespace DHLClient.LocationUnified
{
    /// <summary>
    /// Represents the closing periods of a DHL service point location
    /// </summary>
    public class LocationClosurePeriodResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Type"/> property
        /// </summary>
        private string? mType;

        #endregion

        #region Public Properties

        /// <summary>
        /// Reason for the closure
        /// </summary>
        /// <example>holiday</example>
        [JsonProperty("type")]
        public string Type
        {
            get => mType ?? string.Empty;
            set => mType = value;
        }

        /// <summary>
        /// A date value in ISO 8601 format (`2017-06-21`) or a combination of date and time of day (`2017-06-21T14:07:17Z`)
        /// </summary>
        /// <example>2018-03-02T07:53:47Z</example>
        [JsonProperty("fromDate")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimestampJsonConverter))]
        public DateTimeOffset FromDate { get; set; }

        /// <summary>
        /// A date value in ISO 8601 format (`2017-06-21`) or a combination of date and time of day (`2017-06-21T14:07:17Z`)
        /// </summary>
        /// <example>2018-03-02T07:53:47Z</example>
        [JsonProperty("toDate")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimestampJsonConverter))]
        public DateTimeOffset ToDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationClosurePeriodResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Type: {Type}, From Date: {FromDate}, To Date: {ToDate}";


        #endregion
    }
}
