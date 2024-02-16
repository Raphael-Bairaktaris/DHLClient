using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="BarcodePositionType"/> to <see cref="string"/>
    /// </summary>
    public class BarcodePositionTypeToStringJsonConverter : BaseEnumJsonConverter<BarcodePositionType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BarcodePositionTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Method

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BarcodePositionType, string> GetMapper() => DHLClientConstants.BarcodePositionTypeToStringMapper;

        #endregion
    }
}
