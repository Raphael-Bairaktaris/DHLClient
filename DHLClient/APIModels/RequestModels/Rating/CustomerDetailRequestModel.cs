using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer detail
    /// </summary>
    public class CustomerDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Address definition for rating related services
        /// </summary>
        [JsonProperty("shipperDetails")]
        public ShipmentPickupDetailRequestModel? ShipperDetails { get; set; }

        /// <summary>
        /// Address definition for rating related services
        /// </summary>
        [JsonProperty("receiverDetails")]
        public ShipmentPickupDetailRequestModel? ReceiverDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerDetailRequestModel() : base()
        {

        }

        #endregion
    }
}