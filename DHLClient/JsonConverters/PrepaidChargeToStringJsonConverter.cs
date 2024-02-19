using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PrepaidCharge"/> to <see cref="string"/>
    /// </summary>
    public class PrepaidChargeToStringJsonConverter : BaseEnumJsonConverter<PrepaidCharge>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PrepaidChargeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PrepaidCharge, string> GetMapper() => DHLClientConstants.PrepaidChargeToStringMapper;

        #endregion
    }
}
