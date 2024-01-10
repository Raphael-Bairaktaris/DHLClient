using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Representa a service code dependency rule groups response
    /// </summary>
    public class ProductServiceCodeDependencyRuleGroupsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="DependetServiceCode"/> property
        /// </summary>
        private string? mDependetServiceCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Dependent special service charge code where the rule groups are applied.
        /// </summary>
        [JsonProperty("dependentServiceCode")]
        public string DependetServiceCode
        {
            get => mDependetServiceCode ?? string.Empty;
            set => mDependetServiceCode = value;
        }

        /// <summary>
        /// The dependency rule group
        /// </summary>
        [JsonProperty("dependencyRuleGroup")]
        public ProductDependencyRuleGroupResponseModel DependencyRuleGroup { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductServiceCodeDependencyRuleGroupsResponseModel() : base()
        {

        }

        #endregion
    }
}