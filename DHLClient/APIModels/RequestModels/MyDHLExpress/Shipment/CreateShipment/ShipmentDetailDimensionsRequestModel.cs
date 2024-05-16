using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment weight
    /// </summary>
    public class ShipmentDetailDimensionsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Length of the package
        /// </summary>
        /// <example>15.001</example>
        [JsonProperty("length")]
        public double Length { get; set; }

        /// <summary>
        /// Width of the package
        /// </summary>
        /// <example>15.001</example>
        [JsonProperty("width")]
        public double Width { get; set; }

        /// <summary>
        /// Height of the package
        /// </summary>
        /// <example>40.001</example>
        [JsonProperty("height")]
        public double Height { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailDimensionsRequestModel() : base()
        {

        }

        #endregion
    }
}