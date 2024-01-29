using Newtonsoft.Json;

namespace DHLClient
{
    public class ServicePointDetailOpeningHourResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Weekday for which this opening hours entity is valid.
        /// </summary>
        [JsonProperty("dayOfWeek")]
        public DHLDayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// The opening time of this entity
        /// </summary>
        [JsonProperty("openingTime")]
        public TimeOnly OpeningTime { get; set; }

        /// <summary>
        /// The closing time of this entity
        /// </summary>
        [JsonProperty("closingTime")]
        public TimeOnly ClosingTime { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailOpeningHourResponseModel() : base()
        {

        }

        #endregion
    }
}