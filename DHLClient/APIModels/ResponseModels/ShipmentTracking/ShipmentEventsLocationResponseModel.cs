using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment event location response 
    /// </summary>
    public class ShipmentEventsLocationResponseModel : ShipmentDetailOriginAddressResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The service point
        /// </summary>
        [JsonProperty("servicePoint")]
        public ShipmentEventsLocationServicePointResponseModel ServicePoint { get; set; }

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