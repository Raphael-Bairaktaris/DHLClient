namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumToIntJsonConverter{T}"/> that is used for converting a <see cref="DHLDayOfWeek"/> to <see cref="int"/>
    /// </summary>
    public class DHLDayOfWeekToIntJsonConverter : BaseEnumToIntJsonConverter<DHLDayOfWeek>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DHLDayOfWeekToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DHLDayOfWeek, int> GetMapper() => DHLClientConstants.DHLDayOfWeekTypeToIntMapper;

        #endregion
    }
}
