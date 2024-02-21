using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail opening hour response
    /// </summary>
    public class ServicePointDetailOpeningHoursResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="OpeningHours"/> property
        /// </summary>
        private IEnumerable<ServicePointDetailOpeningHourResponseModel>? mOpeningHours;

        /// <summary>
        /// The member of the <see cref="HolidayDates"/> property
        /// </summary>
        private IEnumerable<string>? mHolidayDates;

        /// <summary>
        /// The member of the <see cref="HolidaysDates"/> property
        /// </summary>
        private IEnumerable<string>? mHolidaysDates;

        /// <summary>
        /// The member of the <see cref="Holiday"/> property
        /// </summary>
        private ServicePointDetailHolidayResponseModel? mHolidays;

        #endregion

        #region Public Properties

        /// <summary>
        /// Multiple opening hours entities can exist for the same week day.
        /// </summary>
        [JsonProperty("openingHours")]
        public IEnumerable<ServicePointDetailOpeningHourResponseModel> OpeningHours
        {
            get => mOpeningHours ?? Enumerable.Empty<ServicePointDetailOpeningHourResponseModel>();
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
        /// Holiday details with date
        /// </summary>
        [JsonProperty("holidaysDates")]
        public IEnumerable<string> HolidaysDates
        {
            get => mHolidaysDates ?? Enumerable.Empty<string>();
            set => mHolidaysDates = value;
        }

        /// <summary>
        /// Holiday details
        /// </summary>
        [JsonProperty("holidays")]
        public ServicePointDetailHolidayResponseModel Holidays
        {
            get => mHolidays ??= new ServicePointDetailHolidayResponseModel();
            set => mHolidays = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailOpeningHoursResponseModel() : base()
        {

        }

        #endregion
    }
}