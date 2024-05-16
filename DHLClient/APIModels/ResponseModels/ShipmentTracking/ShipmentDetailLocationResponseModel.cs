using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a shipment origin response
    /// </summary>
    public class ShipmentDetailLocationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private ShipmentDetailAddressResponseModel? mAddress;

        /// <summary>
        /// The member of the <see cref="ServicePoint"/> property
        /// </summary>
        private ShipmentDetailServicePointResponseModel? mServicePoint;

        #endregion

        #region Public Properties

        /// <summary>
        /// The address
        /// </summary>
        [JsonProperty("address")]
        public ShipmentDetailAddressResponseModel Address
        {
            get => mAddress ?? new ShipmentDetailAddressResponseModel();
            set => mAddress = value;
        }

        /// <summary>
        /// The shipment service point details
        /// </summary>
        [JsonProperty("servicePoint")]
        public ShipmentDetailServicePointResponseModel ServicePoint
        {
            get => mServicePoint ??= new ShipmentDetailServicePointResponseModel();
            set => mServicePoint = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailLocationResponseModel() : base()
        {

        }

        #endregion
    }
}
