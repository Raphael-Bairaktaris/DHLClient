namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="CarrierName"/> to <see cref="string"/>
    /// </summary>
    public class CarrierNameToStringJsonConverter : BaseEnumJsonConverter<CarrierName>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CarrierNameToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CarrierName, string> GetMapper() => DHLClientConstants.CarrierNameToStringMapper;

        #endregion
    }
}
