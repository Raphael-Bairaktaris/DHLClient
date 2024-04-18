namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DHLDayOfWeek"/> to <see cref="string"/>
    /// </summary>
    public class DHLDayOfWeekTypeToStringJsonConverter : BaseEnumJsonConverter<DHLDayOfWeek>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DHLDayOfWeekTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DHLDayOfWeek, string> GetMapper() => DHLClientConstants.DHLDayOfWeekTypeToStringMapper;

        #endregion
    }
}
