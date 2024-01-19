using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details dimensions response
    /// </summary>
    public class ShipmentDetailDimensionResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The width
        /// </summary>
        /// <example>15</example>
        [JsonProperty("width")]
        public double Width { get; set; }

        /// <summary>
        /// The height
        /// </summary>
        /// <example>40</example>
        [JsonProperty("height")]
        public double Height { get; set; }

        /// <summary>
        /// The length
        /// </summary>
        /// <example>15</example>
        [JsonProperty("length")]
        public double Length { get; set; }

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