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
        [JsonRequired]
        [JsonProperty("shipperDetails")]
        public IEnumerable<ShipperDetailRequestModel>? ShipperDetails { get; set; }

        /// <summary>
        /// Address definition for rating related services
        /// </summary>
        [JsonRequired]
        [JsonProperty("receiverDetails")]
        public IEnumerable<ReceiverDetailsRequestModel>? ReceiverDetails { get; set; }

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