using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// List of the opening hours of the DHL Service Point location
    /// </summary>
    public class ServicePointLocationOpeningHoursResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The closing hours of the place or service on the given day(s) of the week
        /// </summary>
        [JsonProperty("closes")]
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
