using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service code mutually exclusive group response
    /// </summary>
    public class ProductServiceCodeMutuallyExclusiveGroupsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceCodeRuleName"/> property
        /// </summary>
        private string? mServiceCodeRuleName;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        #endregion

        #region Public Properties

        /// <summary>
        /// Mutually exclusive serviceCode group name
        /// </summary>
        /// <example>Exclusive Billing Services</example>
        [JsonProperty("serviceCodRuleName")]
        public string ServiceCodeRuleName
        {
            get => mServiceCodeRuleName ?? string.Empty;
            set => mServiceCodeRuleName = value;
        }

        /// <summary>
        /// Mutually exclusive serviceCode group description
        /// </summary>
        /// <example>Mutually exclusive Billing Services - shipment can contain just one of following</example>
        [JsonProperty("description")]
        public string Decription
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The special service charge code
        /// </summary>
        [JsonProperty("serviceCodes")]
        public ProductServiceCodeMutuallyExclusiveGroupsServiceCodesResponseModel ServiceCodes { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductServiceCodeMutuallyExclusiveGroupsResponseModel() : base()
        {

        }

        #endregion
    }
}
