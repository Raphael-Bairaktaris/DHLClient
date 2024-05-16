namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DataSetType"/> to <see cref="string"/>
    /// </summary>
    public class DataSetTypeToStringJsonConverter : BaseEnumJsonConverter<DataSetType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DataSetTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DataSetType, string> GetMapper() => DHLClientConstants.DataSetTypeToStringMapper;

        #endregion
    }
}
