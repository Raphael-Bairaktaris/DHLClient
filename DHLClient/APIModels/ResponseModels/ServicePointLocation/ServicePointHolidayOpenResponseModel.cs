using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an open service point holiday response 
    /// </summary>
    public class ServicePointHolidayOpenResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Date – when is open during holidays
        /// </summary>
        [JsonProperty("date")]
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
        public ServicePointHolidayOpenResponseModel() : base()
        {

        }

        #endregion
    }
}