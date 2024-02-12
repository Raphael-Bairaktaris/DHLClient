namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used to convert a <see cref="CarrierName"/> to <see cref="string"/>
    /// </summary>
    public class CarrierNameQuaryArgumentConverter : BaseQueryArgumentConverter<CarrierName>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CarrierNameQuaryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(CarrierName value) => DHLClientConstants.CarrierNameToStringMapper[value];

        #endregion
    }
}
