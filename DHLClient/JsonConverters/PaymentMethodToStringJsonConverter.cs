// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentMethod"/> to <see cref="string"/>
    /// </summary>
    public class PaymentMethodToStringJsonConverter : BaseEnumJsonConverter<PaymentMethod>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PaymentMethod, string> GetMapper() => DHLClientConstants.PaymentMethodToStringMapper;

        #endregion
    }
}
