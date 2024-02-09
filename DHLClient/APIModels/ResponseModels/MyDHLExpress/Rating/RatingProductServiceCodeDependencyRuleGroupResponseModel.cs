using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service code dependency rule group response
    /// </summary>
    public class RatingProductServiceCodeDependencyRuleGroupResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="DependentServiceCode"/> property
        /// </summary>
        private string? mDependentServiceCode;

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
        public IEnumerable<DependencyRuleGroupDetailResponseModel> DependencyRuleGroup { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingProductServiceCodeDependencyRuleGroupResponseModel() : base()
        {

        }

        #endregion
    }
}