using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a dependency rule group response
    /// </summary>
    public class ProductDependencyRuleGroupResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="DependencyRuleName"/> property
        /// </summary>
        private string? mDependencyRuleName;

        /// <summary>
        /// The member of the <see cref="DependencyDescription"/> property
        /// </summary>
        private string? mDependencyDescription;

        /// <summary>
        /// The member of the <see cref="DependencyCondition"/> property
        /// </summary>
        private string? mDependencyCondition;

        #endregion

        #region Public Properties

        /// <summary>
        /// Dependency rule group name
        /// </summary>
        /// <example>Labelfree and PLT rule</example>
        [JsonProperty("dependencyRuleName")]
        public string DependencyRuleName
        {
            get => mDependencyRuleName ?? string.Empty;
            set => mDependencyRuleName = value;
        }

        /// <summary>
        /// Dependency rule group description
        /// </summary>
        /// <example>Labelfree requires Paperless Trade (PLT) only if PLT is allowed for product globaly</example>
        [JsonProperty("dependencyDescription")]
        public string DependencyDescription
        {
            get => mDependencyDescription ?? string.Empty;
            set => mDependencyDescription = value;
        }

        /// <summary>
        /// Dependency rule group condition statement
        /// </summary>
        /// <example>Must provide the requiredServiceCode if it is allowed for the productCode</example>
        [JsonProperty("dependencyCondition")]
        public string DependencyCondition
        {
            get => mDependencyCondition ?? string.Empty;
            set => mDependencyCondition = value;
        }

        /// <summary>
        /// The required service codes
        /// </summary>
        public ProductDependencyRuleGroupRequiredServiceCodesResponseModel RequiredServiceCodes { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductDependencyRuleGroupResponseModel() : base()
        {

        }

        #endregion
    }
}