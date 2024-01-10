using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service code mutually exclusive groups service codes response
    /// </summary>
    public class ProductServiceCodeMutuallyExclusiveGroupsServiceCodesResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The special service charge code
        /// </summary>
        [JsonProperty("serviceCode")]
        public SpecialServiceChargeCode ServiceCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductServiceCodeMutuallyExclusiveGroupsServiceCodesResponseModel() : base()
        {

        }

        #endregion
    }
}