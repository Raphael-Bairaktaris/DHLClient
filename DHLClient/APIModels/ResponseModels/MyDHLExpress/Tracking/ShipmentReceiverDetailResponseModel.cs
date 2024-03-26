using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a receiver detail response
    /// </summary>
    public class ShipmentReceiverDetailResponseModel : ShipperPostalAddressResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceArea"/> property
        /// </summary>
        private ReceiverServiceAreaResponseModel? mServiceArea;

        #endregion

        #region Public Properties

        /// <summary>
        /// The receiver's service area
        /// </summary>
        [JsonProperty("serviceArea")]
        public ReceiverServiceAreaResponseModel ServiceArea
        {
            get => mServiceArea ??= new ReceiverServiceAreaResponseModel();
            set => mServiceArea = value;
        }

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