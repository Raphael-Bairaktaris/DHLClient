using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a closed service point response
    /// </summary>
    public class ServicePointHolidayClosedResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Date – start when it is closed
        /// </summary>
        [JsonProperty("from")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly From { get; set; }

        /// <summary>
        /// Date – end when it is closed
        /// </summary>
        [JsonProperty("to")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly To { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointHolidayClosedResponseModel() : base()
        {

        }

        #endregion
    }
}