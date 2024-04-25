using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail holiday open response
    /// </summary>
    public class ServicePointDetailHolidayOpenResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Date – when is open during holidays
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter), true)]
        public DateOnly Date { get; set; }

        /// <summary>
        /// Time – beginning of open hours
        /// </summary>
        [JsonProperty("from")]
        public TimeOnly From { get; set; }

        /// <summary>
        /// Time – end of open hours
        /// </summary>
        [JsonProperty("to")]
        public TimeOnly To { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailHolidayOpenResponseModel() : base()
        {

        }

        #endregion


        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Date: {Date}, From: {From}, To: {To}";

        #endregion
    }
}