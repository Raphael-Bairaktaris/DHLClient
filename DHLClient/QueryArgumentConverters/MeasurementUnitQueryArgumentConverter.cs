namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="MeasurmentUnit"/> to <see cref="string"/>
    /// </summary>
    public class MeasurementUnitQueryArgumentConverter : BaseQueryArgumentConverter<MeasurmentUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementUnitQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(MeasurmentUnit value) => DHLClientConstants.MeasurmentUnitToStringMapper[value];

        #endregion
    }
}
