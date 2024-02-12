namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used to convert a <see cref="DeliveryType"/> to <see cref="string"/>
    /// </summary>
    public class DeliveryTypeQueryArgumentConverter : BaseQueryArgumentConverter<DeliveryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(DeliveryType value) => DHLClientConstants.DeliveryTypeToStringMapper[value];

        #endregion
    }
}
