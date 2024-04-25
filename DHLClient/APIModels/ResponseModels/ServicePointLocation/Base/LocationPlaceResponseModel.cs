using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point location by place response
    /// </summary>
    public class LocationPlaceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private LocationAddressResponseModel? mAddress;

        /// <summary>
        /// The member of the <see cref="ContainedInPlace"/>
        /// </summary>
        private LocationContainedInPlaceResponseModel? mContainedInPlace;

        #endregion

        #region Public Properties

        /// <summary>
        /// Address properties
        /// </summary>
        [JsonProperty("address")]
        public LocationAddressResponseModel Address
        {
            get => mAddress ??= new LocationAddressResponseModel();
            set => mAddress = value;
        }

        /// <summary>
        /// Geometric coordinates
        /// </summary>
        [JsonProperty("geo")]
        public Coordinates GeometricCoordinates { get; set; }

        /// <summary>
        /// Contained in place
        /// </summary>
        [JsonProperty("containedInPlace")]
        public LocationContainedInPlaceResponseModel ContainedInPlace
        {
            get => mContainedInPlace ??= new LocationContainedInPlaceResponseModel();
            set => mContainedInPlace = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationPlaceResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Geometric Coordinates: {GeometricCoordinates}";

        #endregion

    }
}
