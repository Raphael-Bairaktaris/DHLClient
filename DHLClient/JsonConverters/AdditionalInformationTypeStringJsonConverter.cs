namespace DHLClient.JsonConverters
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that is used to convert an <see cref="AdditionalInformationType"/> to <see cref="string"/>
    /// </summary>
    public class AdditionalInformationTypeStringJsonConverter : BaseEnumJsonConverter<AdditionalInformationType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AdditionalInformationTypeStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<AdditionalInformationType, string> GetMapper() => DHLClientConstants.AdditionalInformationTypeToStringMapper;

        #endregion
    }
}
