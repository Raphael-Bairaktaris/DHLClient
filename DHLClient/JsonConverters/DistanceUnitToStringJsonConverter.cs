namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DistanceUnit"/> to <see cref="string"/>
    /// </summary>
    public class DistanceUnitToStringJsonConverter : BaseEnumJsonConverter<DistanceUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DistanceUnitToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DistanceUnit, string> GetMapper() => DHLClientConstants.DistanceUnitToStringMapper;

        #endregion
    }
}
