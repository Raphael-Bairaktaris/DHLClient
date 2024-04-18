using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point average capacity day of week
    /// </summary>
    public class LocationAverageCapacityDayOfWeekResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Capacity"/> property
        /// </summary>
        private string? mCapacity;

        #endregion

        #region Public Properties

        /// <summary>
        /// The day of the week as defined at
        /// </summary>
        /// <remarks> https://schema.org/DayOfWeek </remarks>
        [JsonProperty("dayOfWeek")]
        [JsonConverter(typeof(DHLDayOfWeekTypeToStringJsonConverter))]
        public DHLDayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Information on the average availability of locker capacity (only available in Germany).
        /// </summary>
        [JsonProperty("capacity")]
        public string Capacity
        {
            get => mCapacity ?? string.Empty;
            set => mCapacity = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationAverageCapacityDayOfWeekResponseModel() : base()
        {

        }

        #endregion
    }
}
