using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details dimensions response
    /// </summary>
    public class ShipmentDetailsDimensionsResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The width
        /// </summary>
        [JsonProperty("width")]
        public double Width { get; set; }

        /// <summary>
        /// The height
        /// </summary>
        [JsonProperty("height")]
        public double Height { get; set; }

        /// <summary>
        /// The length
        /// </summary>
        [JsonProperty("length")]
        public double Length { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsDimensionsResponseModel() : base()
        {

        }

        #endregion
    }
}