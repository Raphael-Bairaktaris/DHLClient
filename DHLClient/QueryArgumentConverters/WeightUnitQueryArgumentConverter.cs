namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert a <see cref="WeightUnit"/> to <see cref="string"/>
    /// </summary>
    public class WeightUnitQueryArgumentConverter : BaseQueryArgumentConverter<WeightUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public WeightUnitQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(WeightUnit value) => DHLClientConstants.WeightUnitToStringMapper[value];

        #endregion
    }
}
