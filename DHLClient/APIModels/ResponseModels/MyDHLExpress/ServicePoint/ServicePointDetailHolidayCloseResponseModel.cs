using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a service point detail holiday closed response
    /// </summary>
    public class ServicePointDetailHolidayCloseResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Date – start when it is closed
        /// </summary>
        /// <example>7-4-2023</example>
        /// TODO
        [JsonProperty("from")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter), true)]
        public DateOnly From { get; set; }

        /// <summary>
        /// Date – end when it is closed
        /// </summary>
        /// <example>7-4-2023</example>
        [JsonProperty("to")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter), true)]
        public DateOnly To { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailHolidayCloseResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"From: {From}, To: {To}";

        #endregion
    }
}