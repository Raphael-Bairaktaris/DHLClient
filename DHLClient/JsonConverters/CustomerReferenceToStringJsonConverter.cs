namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="CustomerReference"/> to <see cref="string"/>
    /// </summary>
    public class CustomerReferenceToStringJsonConverter : BaseEnumJsonConverter<CustomerReference>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerReferenceToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CustomerReference, string> GetMapper() => DHLClientConstants.CustomerReferenceToStringMapper;

        #endregion
    }
}
