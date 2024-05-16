namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="TransportationMode"/> to <see cref="string"/>
    /// </summary>
    public class TransportationModeToStringJsonConverter : BaseEnumJsonConverter<TransportationMode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransportationModeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TransportationMode, string> GetMapper() => DHLClientConstants.TransportationModeToStringMapper;

        #endregion
    }
}
