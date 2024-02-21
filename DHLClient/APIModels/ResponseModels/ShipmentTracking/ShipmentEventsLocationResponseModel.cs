using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment event location response 
    /// </summary>
    public class ShipmentEventsLocationResponseModel : ShipmentDetailOriginAddressResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServicePoint"/> property
        /// </summary>
        private ShipmentEventsLocationServicePointResponseModel? mServicePoint;

        #endregion

        #region Public Properties

        /// <summary>
        /// The service point
        /// </summary>
        [JsonProperty("servicePoint")]
        public ShipmentEventsLocationServicePointResponseModel ServicePoint 
        { 
            get => mServicePoint ??= new ShipmentEventsLocationServicePointResponseModel();
            set => mServicePoint = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentEventsLocationResponseModel() : base()
        {

        }

        #endregion
    }
}