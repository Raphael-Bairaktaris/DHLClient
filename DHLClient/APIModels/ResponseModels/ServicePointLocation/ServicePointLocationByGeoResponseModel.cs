using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents the geo coordinates of the DHL service point location
    /// </summary>
    public class ServicePointLocationByGeoResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The latitude
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByGeoResponseModel() : base()
        {

        }

        #endregion
    }
}
