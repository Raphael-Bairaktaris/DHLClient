using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a line item quantity
    /// </summary>
    public class ShipmentDetailLineItemQuantityRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter number of pieces in the line item
        /// </summary>
        /// <example>1</example>
        [JsonRequired]
        [JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Please provide correct unit of measurement
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(QuantityUnitOfMeasurementToStringJsonConverter))]
        public QuantityUnitOfMeasurement? UnitOfMeasurement { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailLineItemQuantityRequestModel() : base()
        {

        }

        #endregion
    }
}