using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment detail quantity response
    /// </summary>
    public class ShipmentDetailQuantityResponseModel
    {
        #region Public Properties

        /// <summary>
        /// A string or text indicating the unit of measurement
        /// </summary>
        [JsonProperty("unitText")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit UnitText { get; set; }

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
        public ShipmentDetailQuantityResponseModel() : base()
        {

        }

        #endregion
    }
}