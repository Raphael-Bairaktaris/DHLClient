using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point opening hour response
    /// </summary>
    public class ServicePointLocationOpeningHoursResponseModel
    {
        #region Public region

        /// <summary>
        /// The closing hours of the place or service on the given day(s) of the week
        /// </summary>
        [JsonProperty("closes")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public TimeOnly Closes { get; set; }

        /// <summary>
        /// The opening hours of the place or service on the given day(s) of the week
        /// </summary>
        [JsonProperty("opens")]
        public TimeOnly Opens { get; set; }

        /// <summary>
        /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.
        /// </summary>
        [JsonProperty("dayOfWeek")]
        [JsonConverter(typeof(DHLDayOfWeekTypeToStringJsonConverter))]
        public DHLDayOfWeek DayOfWeek { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationOpeningHoursResponseModel() : base()
        {

        }

        #endregion
    }
}