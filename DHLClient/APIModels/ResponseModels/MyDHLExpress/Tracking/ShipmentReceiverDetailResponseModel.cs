using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a receiver detail response
    /// </summary>
    public class ShipmentReceiverDetailResponseModel : ShipperPostalAddressResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The receiver's service area
        /// </summary>
        [JsonProperty("serviceArea")]
        public ReceiverServiceAreaResponseModel ServiceArea { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentReceiverDetailResponseModel() : base()
        {

        }

        #endregion
    }
}