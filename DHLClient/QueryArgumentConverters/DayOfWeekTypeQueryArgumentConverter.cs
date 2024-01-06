namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="DayOfWeekType"/> to a <see cref="string"/> 
    /// </summary>
    public class DayOfWeekTypeQueryArgumentConverter : BaseQueryArgumentConverter<DayOfWeekType>
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
        public override string Convert(DayOfWeekType value) => DHLClientConstants.DayOfWeekTypeToStringMapper[value];

        #endregion
    }
}
