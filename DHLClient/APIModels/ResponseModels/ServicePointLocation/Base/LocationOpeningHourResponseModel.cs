using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point opening hour response
    /// </summary>
    public class LocationOpeningHoursResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The closing hours of the place or service on the given day(s) of the week
        /// </summary>
        /// <example>16:30</example>
        [JsonProperty("closes")]
        [JsonConverter(typeof(TimeOnlyToStringJsonConverter))]
        public TimeOnly Closes { get; set; }

        /// <summary>
        /// The opening hours of the place or service on the given day(s) of the week
        /// </summary>
        /// <example>10:00</example>
        [JsonProperty("opens")]
        [JsonConverter(typeof(TimeOnlyToStringJsonConverter))]
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
        public LocationOpeningHoursResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Closes: {Closes}, Opens: {Opens}, Day of week: {DayOfWeek}";

        #endregion
    }
}