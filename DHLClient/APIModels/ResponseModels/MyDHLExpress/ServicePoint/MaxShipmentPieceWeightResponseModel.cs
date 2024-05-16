using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a shipment max weight response
    /// </summary>
    public class MaxShipmentPieceWeightResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="UOM"/> property 
        /// </summary>
        private string? mUOM;

        #endregion

        #region Public Properties

        /// <summary>
        /// Value in BigDecimal
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }

        /// <summary>
        /// UOM
        /// </summary>
        [JsonProperty("uom")]
        public string UOM
        {
            get => mUOM ?? string.Empty;
            set => mUOM = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MaxShipmentPieceWeightResponseModel() : base()
        {

        }

        #endregion
    }
}