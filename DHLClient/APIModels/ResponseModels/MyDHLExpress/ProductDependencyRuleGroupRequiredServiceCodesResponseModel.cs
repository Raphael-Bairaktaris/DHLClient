using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a dependency rule group required service code response
    /// </summary>
    public class ProductDependencyRuleGroupRequiredServiceCodesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceCode"/> property
        /// </summary>
        private string? mServiceCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Required special service code
        /// </summary>
        /// <example>WY</example>
        [JsonProperty("serviceCode")]
        public string ServiceCode
        {
            get => mServiceCode ?? string.Empty;
            set => mServiceCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductDependencyRuleGroupRequiredServiceCodesResponseModel() : base()
        {

        }

        #endregion
    }
}