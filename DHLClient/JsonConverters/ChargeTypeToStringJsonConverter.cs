namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ChargeType"/> to <see cref="string"/>
    /// </summary>
    public class ChargeTypeToStringJsonConverter : BaseEnumJsonConverter<ChargeType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChargeTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ChargeType, string> GetMapper() => DHLClientConstants.ChargeTypeToStringMapper;

        #endregion
    }
}
