using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail shipment limitation response
    /// </summary>
    public class ServicePointDetailShipmentLimitationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="MaxNumberOfPieces"/> property
        /// </summary>
        private MaxShipmentPieceWeightResponseModel? mMaxNumberOfPieces;

        /// <summary>
        /// The member of the <see cref="MaxShipmentWeight"/> property
        /// </summary>
        private MaxShipmentPieceWeightResponseModel? mMaxShipmentWeight;

        #endregion

        #region Public Properties

        /// <summary>
        /// Max. weight per piece
        /// </summary>
        [JsonProperty("maxNumberOfPieces")]
        public MaxShipmentPieceWeightResponseModel MaxNumberOfPieces
        {
            get => mMaxNumberOfPieces ??= new MaxShipmentPieceWeightResponseModel();
            set => mMaxNumberOfPieces = value;
        }

        /// <summary>
        /// Max. weight per piece
        /// </summary>
        [JsonProperty("maxShipmentWeight")]
        public MaxShipmentPieceWeightResponseModel MaxShipmentWeight
        {
            get => mMaxShipmentWeight ??= new MaxShipmentPieceWeightResponseModel();
            set => mMaxShipmentWeight = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailShipmentLimitationResponseModel() : base()
        {

        }

        #endregion
    }
}