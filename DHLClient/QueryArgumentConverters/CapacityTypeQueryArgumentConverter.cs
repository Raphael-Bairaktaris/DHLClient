namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="CapacityType"/> to a <see cref="string"/>
    /// </summary>
    public class CapacityTypeQueryArgumentConverter : BaseQueryArgumentConverter<CapacityType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CapacityTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(CapacityType value) => DHLClientConstants.CapacityTypeToStringMapper[value];

        #endregion
    }
}
