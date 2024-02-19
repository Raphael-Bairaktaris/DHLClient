using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating additional information
    /// </summary>
    public class ShipmentDetailGetAdditionalInformationRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Provide type code of data that can be returned in response.
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ValueAddedServiceToStringJsonConverter))]
        public ValueAddedService TypeCode { get; set; }

        /// <summary>
        /// Indicates if additional information is requested 
        /// </summary>
        [JsonRequired]
        [JsonProperty("isRequested")]
        public bool IsRequested { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailGetAdditionalInformationRequestModel() : base()
        {

        }

        #endregion
    }
}