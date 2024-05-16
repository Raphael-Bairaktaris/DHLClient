namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="ShippingRole"/> to <see cref="string"/>
    /// </summary>
    public class ShippingRoleToStringJsonConverter : BaseEnumJsonConverter<ShippingRole>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShippingRoleToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ShippingRole, string> GetMapper() => DHLClientConstants.ShippingRoleToStringMapper;

        #endregion
    }
}
