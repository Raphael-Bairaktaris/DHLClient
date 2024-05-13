namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumEnumerableJsonConverter{T}"/> that converts a collection of <see cref="BusinessPartyType"/>s to <see cref="string"/>
    /// </summary>
    public class BusinessPartyEnumerableToStringJsonConverter : BaseEnumEnumerableJsonConverter<BusinessPartyType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BusinessPartyEnumerableToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BusinessPartyType, string> GetMapper() => DHLClientConstants.BusinessPartyTypeToStringMapper;

        #endregion
    }
}
