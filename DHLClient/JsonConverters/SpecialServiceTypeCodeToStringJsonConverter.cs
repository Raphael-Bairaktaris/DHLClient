using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="SpecialServiceChargeCode"/> to <see cref="string"/>
    /// </summary>
    public class SpecialServiceTypeCodeToStringJsonConverter : BaseEnumJsonConverter<SpecialServiceChargeCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SpecialServiceTypeCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<SpecialServiceChargeCode, string> GetMapper() => DHLClientConstants.SpecialServiceChargeCodeToStringMapper;

        #endregion
    }
}
