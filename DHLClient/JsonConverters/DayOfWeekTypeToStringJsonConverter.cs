namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DayOfWeekType"/> to <see cref="string"/>
    /// </summary>
    public class DayOfWeekTypeToStringJsonConverter : BaseEnumEnumerableJsonConverter<DayOfWeekType>
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
        protected override IReadOnlyDictionary<DayOfWeekType, string> GetMapper() => DHLClientConstants.DayOfWeekTypeToStringMapper;

        #endregion
    }
}
