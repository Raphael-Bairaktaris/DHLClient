using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details dimensions response
    /// </summary>
    public class ShipmentDetailDimensionResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Width"/> property
        /// </summary>
        private ShipmentDetailDimensionAttributeResponseModel? mWidth;

        /// <summary>
        /// The member of the <see cref="Height"/> property
        /// </summary>
        private ShipmentDetailDimensionAttributeResponseModel? mHeight;

        /// <summary>
        /// The member of the <see cref="Length"/> property
        /// </summary>
        private ShipmentDetailDimensionAttributeResponseModel? mLength;

        #endregion

        #region Public Properties

        /// <summary>
        /// The width
        /// </summary>
        /// <example>15</example>
        [JsonProperty("width")]
        public ShipmentDetailDimensionAttributeResponseModel Width
        {
            get => mWidth ??= new ShipmentDetailDimensionAttributeResponseModel();
            set => mWidth = value;
        }

        /// <summary>
        /// The height
        /// </summary>
        /// <example>40</example>
        [JsonProperty("height")]
        public ShipmentDetailDimensionAttributeResponseModel Height
        {
            get => mHeight ??= new ShipmentDetailDimensionAttributeResponseModel();
            set => mHeight = value;
        }

        /// <summary>
        /// The length
        /// </summary>
        /// <example>15</example>
        [JsonProperty("length")]
        public ShipmentDetailDimensionAttributeResponseModel Length
        {
            get => mLength ??= new ShipmentDetailDimensionAttributeResponseModel();
            set => mLength = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailDimensionResponseModel() : base()
        {

        }

        #endregion
    }
}