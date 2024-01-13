namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DHLDayOfWeek"/> to <see cref="string"/>
    /// </summary>
    public class DayOfWeekTypeToStringJsonConverter : BaseEnumEnumerableJsonConverter<DHLDayOfWeek>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DayOfWeekTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DHLDayOfWeek, string> GetMapper() => DHLClientConstants.DayOfWeekTypeToStringMapper;

        #endregion
    }
}
