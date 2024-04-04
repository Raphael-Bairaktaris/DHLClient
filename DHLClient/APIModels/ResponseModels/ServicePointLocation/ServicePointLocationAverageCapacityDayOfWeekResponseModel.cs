using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point average capacity day of week
    /// </summary>
    public class ServicePointLocationAverageCapacityDayOfWeekResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The day of the week as defined at
        /// </summary>
        /// <remarks> https://schema.org/DayOfWeek </remarks>
        [JsonProperty("dayOfWeek")]
        [JsonConverter(typeof(DHLDayOfWeekTypeToIntJsonConverter))]
        public DHLDayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Information on the average availability of locker capacity (only available in Germany).
        /// </summary>
        [JsonProperty("capacity")]
        [JsonConverter(typeof(CapacityTypeToStringJsonConverter))]
        public CapacityType Capacity { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationAverageCapacityDayOfWeekResponseModel() : base()
        {

        }

        #endregion
    }
}
