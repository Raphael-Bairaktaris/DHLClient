namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DHLDayOfWeek"/> to <see cref="int"/>
    /// </summary>
    public class DHLDayOfWeekTypeToIntJsonConverter : BaseEnumToIntJsonConverter<DHLDayOfWeek>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DHLDayOfWeekTypeToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DHLDayOfWeek, int> GetMapper() => DHLClientConstants.DHLDayOfWeekTypeToIntMapper;

        #endregion
    }
}
