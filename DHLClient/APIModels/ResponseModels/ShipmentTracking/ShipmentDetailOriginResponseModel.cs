using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment origin response
    /// </summary>
    public class ShipmentDetailOriginResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private ShipmentDetailOriginAddressResponseModel? mAddress;

        /// <summary>
        /// The member of the <see cref="ServicePoint"/> property
        /// </summary>
        private ShipmentDetailServicePointResponseModel? mServicePoint;

        #endregion

        #region Public Properties

        /// <summary>
        /// The address
        /// </summary>
        public ShipmentDetailOriginAddressResponseModel Address
        {
            get => mAddress ?? new ShipmentDetailOriginAddressResponseModel();
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
        public ShipmentDetailOriginResponseModel() : base()
        {

        }

        #endregion
    }
}
