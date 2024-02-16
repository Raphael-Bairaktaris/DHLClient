using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a label text
    /// </summary>
    public class ShipmentDetailLabelTextRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Position of the bespoke text
        /// </summary>
        /// <example>left</example>
        [JsonProperty("position")]
        public BarcodePositionType? Position { get; set; }

        /// <summary>
        /// Please enter caption to be printed in the tag value
        /// </summary>
        /// <example>text caption</example>
        [JsonProperty("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Please enter value to be printed for the respective tag in caption
        /// </summary>
        /// <example>text value</example>
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailLabelTextRequestModel() : base()
        {

        }

        #endregion
    }
}