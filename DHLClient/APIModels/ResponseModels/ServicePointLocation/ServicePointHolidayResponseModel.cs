using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point holiday response
    /// </summary>
    public class ServicePointHolidayResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Open"/> property
        /// </summary>
        private ServicePointHolidayOpenResponseModel? mOpen;

        /// <summary>
        /// The member of the <see cref="Closed"/> property
        /// </summary>
        private ServicePointHolidayClosedResponseModel? mClosed;

        #endregion

        #region Public Properties

        /// <summary>
        /// Array of objects: {date, from, to}, where date is date and from and to is time
        /// </summary>
        [JsonProperty("open")]
        public ServicePointHolidayOpenResponseModel Open
        {
            get => mOpen ?? new ServicePointHolidayOpenResponseModel();
            set => mOpen = value;
        }

        /// <summary>
        /// Array of dates:{from, to} when is closed.
        /// </summary>
        [JsonProperty("closed")]
        public ServicePointHolidayClosedResponseModel Closed
        {
            get => mClosed ?? new ServicePointHolidayClosedResponseModel();
            set => mClosed = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointHolidayResponseModel() : base()
        {

        }

        #endregion
    }
}