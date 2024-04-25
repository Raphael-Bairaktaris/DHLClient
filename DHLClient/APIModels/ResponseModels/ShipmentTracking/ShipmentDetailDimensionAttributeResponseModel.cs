using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a dimension detail attribute response
    /// </summary>
    public class ShipmentDetailDimensionAttributeResponseModel
    {
        #region Public Properties

        /// <summary>
        /// A string or text indicating the unit of measurement
        /// </summary>
        [JsonProperty("unitText")]
        [JsonConverter(typeof(WeightUnitToStringJsonConverter))]
        public WeightUnit UnitText { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailDimensionAttributeResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Unit Text: {UnitText}, Value: {Value}";

        #endregion
    }
}