using Newtonsoft.Json;

namespace DHLClient.LocationUnified
{
    /// <summary>
    /// The base for all the single service point location
    /// </summary>
    public class BaseSingleServicePointLocationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Location"/> property
        /// </summary>
        private LocationResponseModel? mLocation;

        #endregion

        #region Public Properties

        /// <summary>
        /// The location
        /// </summary>
        [JsonProperty("location")]
        public LocationResponseModel? Location
        {
            get => mLocation ??= new LocationResponseModel();
            set => mLocation = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseSingleServicePointLocationResponseModel() : base()
        {

        }

        #endregion
    }
}
