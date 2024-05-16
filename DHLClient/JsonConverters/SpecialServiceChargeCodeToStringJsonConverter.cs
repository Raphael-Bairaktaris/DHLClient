namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="SpecialServiceChargeCode"/> to <see cref="string"/>
    /// </summary>
    public class SpecialServiceChargeCodeToStringJsonConverter : BaseEnumJsonConverter<SpecialServiceChargeCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SpecialServiceChargeCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<SpecialServiceChargeCode, string> GetMapper() => DHLClientConstants.SpecialServiceChargeCodeToStringMapper;

        #endregion
    }
}
