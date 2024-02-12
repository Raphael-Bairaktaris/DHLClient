namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="CargoType"/> to a <see cref="string"/>
    /// </summary>
    public class CargoTypeQueryArgumentConverter : BaseQueryArgumentConverter<CargoType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CargoTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(CargoType value) => DHLClientConstants.CargoTypeToStringMapper[value];

        #endregion
    }
}
