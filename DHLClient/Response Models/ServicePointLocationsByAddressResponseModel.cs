using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represent a DHL Service Point locations collection response
    /// </summary>
    public class ServicePointLocationsByAddressResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Locations"/> property
        /// </summary>
        private IEnumerable<ServicePointLocationByAddressResponseModel>? mLocations;

        #endregion

        #region Public Properties

        /// <summary>
        /// The locations
        /// </summary>
        [JsonProperty("locations")]
        public IEnumerable<ServicePointLocationByAddressResponseModel> Locations 
        { 
            get => mLocations ?? Enumerable.Empty<ServicePointLocationByAddressResponseModel>();
            set => mLocations = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationsByAddressResponseModel() : base()
        {

        }

        #endregion
    }
}