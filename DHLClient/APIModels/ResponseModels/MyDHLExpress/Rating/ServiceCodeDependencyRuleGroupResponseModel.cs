using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service code dependency rule group response
    /// </summary>
    public class ServiceCodeDependencyRuleGroupResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="DependentServiceCode"/> property
        /// </summary>
        private string? mDependentServiceCode;

        /// <summary>
        /// The member of the <see cref="DependencyRuleGroup"/> property
        /// </summary>
        private IEnumerable<DependencyRuleGroupDetailResponseModel>? mDependencyRuleGroup;

        #endregion

        #region Public Properties

        /// <summary>
        /// Dependent special service charge code where the rule groups are applied
        /// </summary>
        [JsonProperty("dependentServiceCode")]
        public string DependentServiceCode
        {
            get => mDependentServiceCode ?? string.Empty;
            set => mDependentServiceCode = value;
        }

        /// <summary>
        /// The dependency rule group
        /// </summary>
        [JsonProperty("dependencyRuleGroup")]
        public IEnumerable<DependencyRuleGroupDetailResponseModel> DependencyRuleGroup
        {
            get => mDependencyRuleGroup ?? Enumerable.Empty<DependencyRuleGroupDetailResponseModel>();
            set => mDependencyRuleGroup = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceCodeDependencyRuleGroupResponseModel() : base()
        {

        }

        #endregion
    }
}