namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="DHLDayOfWeek"/> to a <see cref="string"/> 
    /// </summary>
    public class DayOfWeekTypeQueryArgumentConverter : BaseQueryArgumentConverter<DHLDayOfWeek>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DayOfWeekTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(DHLDayOfWeek value) => DHLClientConstants.DayOfWeekTypeToStringMapper[value];

        #endregion
    }
}
