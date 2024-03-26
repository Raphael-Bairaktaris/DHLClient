using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// List of the opening hours of the DHL Service Point location
    /// </summary>
    public class ServicePointLocationOpeningHourResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="OpeningHours"/> property
        /// </summary>
        private ServicePointLocationOpeningHoursResponseModel? mOpeningHours;

        /// <summary>
        /// The member of the <see cref="HolidayDates"/> property
        /// </summary>
        private IEnumerable<string>? mHolidayDates;

        /// <summary>
        /// The member of the <see cref="Holidays"/> property
        /// </summary>
        private ServicePointHolidayResponseModel? mHolidays;

        #endregion

        #region Public Properties

        /// <summary>
        /// Multiple opening hours entities can exist for the same week day.
        /// </summary>
        [JsonProperty("openingHours")]
        public ServicePointLocationOpeningHoursResponseModel OpeningHours
        {
            get => mOpeningHours ??= new ServicePointLocationOpeningHoursResponseModel();
            set => mOpeningHours = value;
        }

        /// <summary>
        /// Holiday details with date
        /// </summary>
        [JsonProperty("holidayDates")]
        public IEnumerable<string> HolidayDates
        {
            get => mHolidayDates ?? Enumerable.Empty<string>();
            set => mHolidayDates = value;
        }

        /// <summary>
        /// Holiday details
        /// </summary>
        [JsonProperty("holidays")]
        public ServicePointHolidayResponseModel Holidays
        {
            get => mHolidays ??= new ServicePointHolidayResponseModel();
            set => mHolidays = value;
        }

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
