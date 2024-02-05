namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ChargeCategory"/> to <see cref="string"/>
    /// </summary>
    public class ChargeCategoryToStringJsonConverter : BaseEnumJsonConverter<ChargeCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChargeCategoryToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ChargeCategory, string> GetMapper() => DHLClientConstants.ChargeCategoryToStringMapper;

        #endregion
    }
}
