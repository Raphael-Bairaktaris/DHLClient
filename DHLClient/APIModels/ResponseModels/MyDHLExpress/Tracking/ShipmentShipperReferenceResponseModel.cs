using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a shipment shipper's reference response
    /// </summary>
    public class ShipmentShipperReferenceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Value"/> property
        /// </summary>
        private string? mValue;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipper's reference value
        /// </summary>
        [JsonProperty("value")]
        public string Value
        {
            get => mValue ?? string.Empty;
            set => mValue = value;
        }

        /// <summary>
        /// The shipper's reference
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ShipperReferenceToStringJsonConverter))]
        public ShipperReference TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentShipperReferenceResponseModel() : base()
        {

        }

        #endregion
    }
}