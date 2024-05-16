namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumEnumerableJsonConverter{T}"/> that converts a <see cref="IEnumerable{CapacityType}"/> to <see cref="string"/>
    /// </summary>
    public class CapacityTypeToStringJsonConverter : BaseEnumEnumerableJsonConverter<CapacityType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CapacityTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        protected override IReadOnlyDictionary<CapacityType, string> GetMapper() => DHLClientConstants.CapacityTypeToStringMapper;

        #endregion
    }
}
