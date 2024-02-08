using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents rating product weight response
    /// </summary>
    public class ProductWeightResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The dimensional weight of the shipment
        /// </summary>
        /// <example>0</example>
        [JsonProperty("volumetric")]
        public double Volumetric { get; set; }

        /// <summary>
        /// The quoted weight of the shipment
        /// </summary>
        [JsonProperty("provided")]
        public double Provided { get; set; }

        /// <summary>
        /// The unit of measurement for the dimensions of the package.
        /// </summary>
        [JsonProperty("unitOfMeasurment")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit UnitOfMeasurment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductWeightResponseModel() : base()
        {

        }

        #endregion
    }
}
