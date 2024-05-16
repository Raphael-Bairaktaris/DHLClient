using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    public class ServicePointDetailOpeningHourResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Weekday for which this opening hours entity is valid.
        /// </summary>
        [JsonProperty("dayOfWeek")]
        [JsonConverter(typeof(DHLDayOfWeekTypeToStringJsonConverter))]
        public DHLDayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// The opening time of this entity
        /// </summary>
        [JsonProperty("openingTime")]
        [JsonConverter(typeof(TimeOnlyToStringJsonConverter))]
        public TimeOnly OpeningTime { get; set; }

        /// <summary>
        /// The closing time of this entity
        /// </summary>
        [JsonProperty("closingTime")]
        [JsonConverter(typeof(TimeOnlyToStringJsonConverter))]
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