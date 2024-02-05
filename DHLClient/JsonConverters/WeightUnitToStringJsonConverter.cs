namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="WeightUnit"/> to <see cref="string"/>
    /// </summary>
    public class WeightUnitToStringJsonConverter : BaseEnumJsonConverter<WeightUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public WeightUnitToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<WeightUnit, string> GetMapper() => DHLClientConstants.WeightUnitToStringMapper;

        #endregion
    }
}
