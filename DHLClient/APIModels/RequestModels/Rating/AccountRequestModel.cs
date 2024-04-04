using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Request model used for creating or updating an account
    /// </summary>
    public class AccountRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter DHL Express account type 
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(ShippingRoleToStringJsonConverter))]
        public ShippingRole TypeCode { get; set; }

        /// <summary>
        /// Please enter DHL Express account number
        /// </summary>
        [JsonRequired]
        [JsonProperty("number")]
        public int Number { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AccountRequestModel() : base()
        {

        }

        #endregion
    }
}