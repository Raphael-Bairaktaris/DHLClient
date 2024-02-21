using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer reference
    /// </summary>
    public class ShipmentCustomerReferenceRequestModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Value"/> property
        /// </summary>
        private string? mValue;

        #endregion

        #region Public Properties

        /// <summary>
        /// Please provide reference
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public string Value 
        { 
            get => mValue ?? string.Empty;
            set => mValue = value;
        }

        /// <summary>
        /// Please provide reference type
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(CustomerReferenceToStringJsonConverter))]
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