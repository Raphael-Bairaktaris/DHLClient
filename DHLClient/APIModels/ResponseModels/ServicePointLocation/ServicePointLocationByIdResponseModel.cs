using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// One location can be known within different business units (providerTypes). They will be known under a unique ID within each business unit domain, as provided.
    /// </summary>
    public class ServicePointLocationByIdResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="LocationId"/>
        /// </summary>
        private string? mLocationId;

        /// <summary>
        /// The member of the <see cref="Provider"/>
        /// </summary>
        private string? mProvider;

        #endregion

        #region Public Properties

        /// <summary>
        /// The ID as how the location is know within this business unit / provider
        /// </summary>
        [JsonProperty("locationId")]
        public string LocationId
        {
            get => mLocationId ?? string.Empty;
            set => mLocationId = value;
        }

        /// <summary>
        /// The business unit of the DHL Service Point location.
        /// </summary>
        [JsonProperty("provider")]
        public string Provider
        {
            get => mProvider ?? string.Empty;
            set => mProvider = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByIdResponseModel() : base()
        {

        }

        #endregion
    }
}
