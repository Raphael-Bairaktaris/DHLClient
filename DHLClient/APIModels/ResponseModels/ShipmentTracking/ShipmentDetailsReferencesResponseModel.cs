using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details references response
    /// </summary>
    public class ShipmentDetailsReferencesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Number"/> property
        /// </summary>
        private string? mNumber;

        #endregion

        #region Public Properties

        /// <summary>
        /// A value of reference
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get => mNumber ?? string.Empty;
            set => mNumber =value;
        }

        /// <summary>
        /// Type of reference
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ReferenceTypeToStringJsonConverter))]
        public ReferenceType Type { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsReferencesResponseModel() : base()
        {

        }

        #endregion
    }
}