using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point location by place response
    /// </summary>
    public class ServicePointLocationByPlaceResponseModel
    {
        #region Private Members

        #endregion

        #region Public Properties

        /// <summary>
        /// Address properties
        /// </summary>
        [JsonProperty("address")]
        public ServicePointLocationByAddressResponseModel Address { get; set; }

        /// <summary>
        /// Geometric coordinates
        /// </summary>
        [JsonProperty("geo")]
        public ServicePointLocationByGeoResponseModel GeometricCoordinates { get; set; }

        /// <summary>
        /// Contained in place
        /// </summary>
        [JsonProperty("containedInPlace")]
        public ServicePointLocationByContainedInPlaceResponseModel ContainedInPlace { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByPlaceResponseModel() : base()
        {

        }

        #endregion

    }
}
