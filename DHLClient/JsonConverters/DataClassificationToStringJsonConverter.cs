namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DataClassification"/> to <see cref="string"/>
    /// </summary>
    public class DataClassificationToStringJsonConverter : BaseEnumJsonConverter<DataClassification>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DataClassificationToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DataClassification, string> GetMapper() => DHLClientConstants.DataClassificationToStringMapper;

        #endregion
    }
}
