using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment limitation by piece response
    /// </summary>
    public class ShipmentLimitaionByPieceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PieceSizeLimit1"/> property
        /// </summary>
        private MaxShipmentPieceWeightResponseModel? mPieceSizeLimit1;

        /// <summary>
        /// The member of the <see cref="PieceSizeLimit2"/> property
        /// </summary>
        private MaxShipmentPieceWeightResponseModel? mPieceSizeLimit2;

        /// <summary>
        /// The member of the <see cref="PieceSizeLimit3"/> property
        /// </summary>
        private MaxShipmentPieceWeightResponseModel? mPieceSiziLimit3;

        /// <summary>
        /// The member of the <see cref="MaxPieceWeight"/> property
        /// </summary>
        private MaxShipmentPieceWeightResponseModel? mMaxPieceWeight;

        #endregion

        #region Public Properties

        /// <summary>
        /// Max. weight per piece
        /// </summary>
        [JsonProperty("placeSizeLimit1")]
        public MaxShipmentPieceWeightResponseModel PieceSizeLimit1 
        { 
            get => mPieceSizeLimit1 ??= new MaxShipmentPieceWeightResponseModel();
            set => mPieceSizeLimit1 = value;
        }

        /// <summary>
        /// Max. weight per piece
        /// </summary>
        [JsonProperty("placeSizeLimit2")]
        public MaxShipmentPieceWeightResponseModel PieceSizeLimit2 
        { 
            get => mPieceSizeLimit2 ??= new MaxShipmentPieceWeightResponseModel();
            set => mPieceSizeLimit2 = value;
        }

        /// <summary>
        /// Max. weight per piece
        /// </summary>
        [JsonProperty("placeSizeLimit3")]
        public MaxShipmentPieceWeightResponseModel PieceSizeLimit3 
        { 
            get => mPieceSiziLimit3 ??= new MaxShipmentPieceWeightResponseModel();
            set => mPieceSiziLimit3 = value;
        }

        /// <summary>
        /// Max. weight per piece
        /// </summary>
        [JsonProperty("maxPieceWeight")]
        public MaxShipmentPieceWeightResponseModel MaxPieceWeight 
        { 
            get => mMaxPieceWeight ??= new MaxShipmentPieceWeightResponseModel();
            set => mMaxPieceWeight = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentLimitaionByPieceResponseModel() : base()
        {

        }

        #endregion
    }
}