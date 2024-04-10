namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that is used for converting a <see cref="MeasurmentUnit"/> to <see cref="string"/>
    /// </summary>
    public class MeasurementUnitToStringJsonConverter : BaseEnumJsonConverter<MeasurmentUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementUnitToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurmentUnit, string> GetMapper() => DHLClientConstants.MeasurmentUnitToStringMapper;

        #endregion
    }
}
