using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// List of the opening hours of the DHL Service Point location
    /// </summary>
    public class ServicePointLocationOpeningHourResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Multiple opening hours entities can exist for the same week day.
        /// </summary>
        [JsonProperty("openingHours")]
        public ServicePointLocationOpeningHoursResponseModel OpeningHours { get; set; }

        /// <summary>
        /// Holiday details with date
        /// </summary>
        [JsonProperty("holidayDates")]
        public IEnumerable<string> HolidayDates { get; set; }

        /// <summary>
        /// Holiday details
        /// </summary>
        [JsonProperty("holidays")]
        public ServicePointHolidayResponseModel Holidays { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationOpeningHourResponseModel() : base()
        {

        }

        #endregion
    }
}
