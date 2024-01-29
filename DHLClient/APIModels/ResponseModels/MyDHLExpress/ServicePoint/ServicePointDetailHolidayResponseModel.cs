using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail holiday response
    /// </summary>
    public class ServicePointDetailHolidayResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Open"/> property
        /// </summary>
        private IEnumerable<ServicePointDetailHolidayOpenResponseModel> mOpen;

        /// <summary>
        /// The member of the <see cref="Closed"/> property
        /// </summary>
        private IEnumerable<ServicePointDetailHolidayCloseResponseModel> mClosed;

        #endregion

        #region Public Properties

        /// <summary>
        /// Array of objects: {date, from, to}, where date is date and from and to is time
        /// </summary>
        [JsonProperty("open")]
        public IEnumerable<ServicePointDetailHolidayOpenResponseModel> Open 
        { 
            get => mOpen ?? Enumerable.Empty<ServicePointDetailHolidayOpenResponseModel>();
            set => mOpen = value;
        }

        /// <summary>
        /// Array of dates:{from, to} when is closed
        /// </summary>
        [JsonProperty("closed")]
        public IEnumerable<ServicePointDetailHolidayCloseResponseModel> Closed 
        { 
            get => mClosed ?? Enumerable.Empty<ServicePointDetailHolidayCloseResponseModel>(); 
            set => mClosed = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailHolidayResponseModel() : base()
        {

        }

        #endregion
    }
}