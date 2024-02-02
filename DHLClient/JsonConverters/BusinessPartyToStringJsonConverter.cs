namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="BusinessPartyType"/> to <see cref="string"/>
    /// </summary>
    public class BusinessPartyToStringJsonConverter : BaseEnumJsonConverter<BusinessPartyType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BusinessPartyToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BusinessPartyType, string> GetMapper() => DHLClientConstants.BusinessPartyTypeToStringMapper;

        #endregion
    }
}
