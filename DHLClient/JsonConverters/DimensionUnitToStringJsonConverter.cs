namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DimensionUnit"/> to <see cref="string"/>
    /// </summary>
    public class DimensionUnitToStringJsonConverter : BaseEnumJsonConverter<DimensionUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DimensionUnitToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DimensionUnit, string> GetMapper() => DHLClientConstants.DimensionUnitToStringMapper;

        #endregion
    }
}
