using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point holiday response
    /// </summary>
    public class ServicePointHolidayResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Array of objects: {date, from, to}, where date is date and from and to is time
        /// </summary>
        [JsonProperty("open")]
        public ServicePointHolidayOpenResponseModel Open { get; set; }

        /// <summary>
        /// Array of dates:{from, to} when is closed.
        /// </summary>
        [JsonProperty("closed")]
        public ServicePointHolidayClosedResponseModel Closed { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointHolidayResponseModel() : base()
        {

        }

        #endregion
    }
}