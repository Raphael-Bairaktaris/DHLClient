using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="SymbologyCode"/> to <see cref="int"/>
    /// </summary>
    public class SymbologyCodeToIntJsonConverter : BaseEnumToIntJsonConverter<SymbologyCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SymbologyCodeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region MyRegion

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<SymbologyCode, int> GetMapper() => DHLClientConstants.SymbologyCodeToIntMapper;

        #endregion
    }
}
