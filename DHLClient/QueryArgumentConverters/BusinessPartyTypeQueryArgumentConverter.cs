namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="BusinessPartyType"/> to a <see cref="string"/>
    /// </summary>
    public class BusinessPartyTypeQueryArgumentConverter : BaseQueryArgumentConverter<BusinessPartyType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BusinessPartyTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(BusinessPartyType value) => DHLClientConstants.BusinessPartyTypeToStringMapper[value];

        #endregion
    }

}