namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumToIntJsonConverter{T}"/> that converts a <see cref="SymbologyCode"/> to <see cref="int"/>
    /// </summary>
    public class SymbologyCodeToIntJsonConverter : BaseEnumToIntJsonConverter<SymbologyCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SymbologyCodeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region MyRegion

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<SymbologyCode, int> GetMapper() => DHLClientConstants.SymbologyCodeToIntMapper;

        #endregion
    }
}
