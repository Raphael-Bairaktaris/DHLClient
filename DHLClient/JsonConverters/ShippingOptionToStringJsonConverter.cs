namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ShippingOption"/> to <see cref="string"/>
    /// </summary>
    public class ShippingOptionToStringJsonConverter : BaseEnumJsonConverter<ShippingOption>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShippingOptionToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ShippingOption, string> GetMapper() => DHLClientConstants.ShippinngOptionToStringMapper;

        #endregion
    }
}
