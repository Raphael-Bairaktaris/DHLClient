using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point location by place response
    /// </summary>
    public class ServicePointLocationByPlaceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private ServicePointLocationByAddressResponseModel? mAddress;

        /// <summary>
        /// The member of the <see cref="GeometricCoordinates"/> property
        /// </summary>
        private ServicePointLocationByGeoResponseModel? mGeometricCoordinates;

        /// <summary>
        /// The member of the <see cref="ContainedInPlace"/>
        /// </summary>
        private ServicePointLocationByContainedInPlaceResponseModel? mContainedInPlace;

        #endregion

        #region Public Properties

        /// <summary>
        /// Address properties
        /// </summary>
        [JsonProperty("address")]
        public ServicePointLocationByAddressResponseModel Address
        {
            get => mAddress ??= new ServicePointLocationByAddressResponseModel();
            set => mAddress = value;
        }

        /// <summary>
        /// Geometric coordinates
        /// </summary>
        [JsonProperty("geo")]
        public ServicePointLocationByGeoResponseModel GeometricCoordinates
        {
            get => mGeometricCoordinates ??= new ServicePointLocationByGeoResponseModel();
            set => mGeometricCoordinates = value;
        }

        /// <summary>
        /// Contained in place
        /// </summary>
        [JsonProperty("containedInPlace")]
        public ServicePointLocationByContainedInPlaceResponseModel ContainedInPlace
        {
            get => mContainedInPlace ??= new ServicePointLocationByContainedInPlaceResponseModel();
            set => mContainedInPlace = value;
        }

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
