using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a dependency rule group detail response
    /// </summary>
    public class DependencyRuleGroupDetailResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="Dependency"/> property
        /// </summary>
        private string? mDependency;

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
        /// <example>Label free and PLT rule</example>
        [JsonProperty("dependency")]
        public string Dependency
        {
            get => mDependency ?? string.Empty;
            set => mDependency = value;
        }

        /// <summary>
        /// Label free requires Paperless Trade (PLT) only if PLT is allowed for product globally
        /// </summary>
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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DependencyRuleGroupDetailResponseModel() : base()
        {

        }

        #endregion
    }
}