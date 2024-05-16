namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ExportReason"/> to <see cref="string"/>
    /// </summary>
    public class ExportReasonToStringJsonConverter : BaseEnumJsonConverter<ExportReason>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExportReasonToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ExportReason, string> GetMapper() => DHLClientConstants.ExportReasonToStringMapper;

        #endregion
    }
}
