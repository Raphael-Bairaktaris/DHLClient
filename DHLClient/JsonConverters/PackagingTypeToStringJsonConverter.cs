// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PackagingType"/> to <see cref="string"/>
    /// </summary>
    public class PackagingTypeToStringJsonConverter : BaseEnumJsonConverter<PackagingType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PackagingTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PackagingType, string> GetMapper() => DHLClientConstants.PackagingTypeToStringMapper;

        #endregion
    }
}
