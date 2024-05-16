using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a service point time zone response
    /// </summary>
    public class ServicePointDetailTimeZoneResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Id"/> property
        /// </summary>
        private string? mId;

        #endregion

        #region Public Properties

        /// <summary>
        /// The id
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get => mId ?? string.Empty;
            set => mId = value;
        }

        /// <summary>
        /// Indicates if the time zone is fixed
        /// </summary>
        [JsonProperty("fixed")]
        public bool IsFixed { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailTimeZoneResponseModel() : base()
        {

        }

        #endregion
    }
}