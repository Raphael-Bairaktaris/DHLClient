namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="IncotermRule"/> to <see cref="string"/>
    /// </summary>
    public class IncotermRuleToStringJsonConverter : BaseEnumJsonConverter<IncotermRule>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncotermRuleToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IncotermRule, string> GetMapper() => DHLClientConstants.IncotermRuleToStringMapper;

        #endregion
    }
}
