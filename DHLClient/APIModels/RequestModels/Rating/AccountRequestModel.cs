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
        /// Please enter DHL Express acount type 
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        public ShippingRole TypeCode { get; set; }

        /// <summary>
        /// Please enter DHL Express account number
        /// </summary>
        [JsonRequired]
        [JsonProperty("number")]
        public double Number { get; set; }

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