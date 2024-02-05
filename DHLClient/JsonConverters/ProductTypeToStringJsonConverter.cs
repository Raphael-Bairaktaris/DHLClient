// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ProductType"/> to <see cref="string"/>
    /// </summary>
    public class ProductTypeToStringJsonConverter : BaseEnumJsonConverter<ProductType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ProductType, string> GetMapper() => DHLClientConstants.ProductTypeToStringMapper;

        #endregion
    }
}
