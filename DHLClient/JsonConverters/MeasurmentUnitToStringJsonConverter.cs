namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="MeasurmentUnit"/> to <see cref="string"/>
    /// </summary>
    public class MeasurmentUnitToStringJsonConverter : BaseEnumJsonConverter<MeasurmentUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurmentUnitToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurmentUnit, string> GetMapper() => DHLClientConstants.MeasurmentUnitToStringMapper;

        #endregion
    }
}
