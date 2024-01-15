using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Address definition for rating related services
        /// </summary>
        [JsonRequired]
        [JsonProperty("shipperDetails")]
        public IEnumerable<ShipperDetailsRequestModel>? ShipperDetails { get; set; }

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