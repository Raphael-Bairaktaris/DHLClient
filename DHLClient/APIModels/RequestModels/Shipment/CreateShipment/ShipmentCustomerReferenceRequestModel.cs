using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer reference
    /// </summary>
    public class ShipmentCustomerReferenceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide reference
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Please provide reference type
        /// </summary>
        [JsonProperty("typeCode")]
        public CustomerReference TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentCustomerReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}