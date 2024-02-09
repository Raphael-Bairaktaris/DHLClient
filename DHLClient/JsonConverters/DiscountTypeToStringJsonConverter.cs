using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="DiscountType"/> to <see cref="string"/>
    /// </summary>
    public class DiscountTypeToStringJsonConverter : BaseEnumJsonConverter<DiscountType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DiscountTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DiscountType, string> GetMapper() => DHLClientConstants.DiscountTypeToStringMapper;

        #endregion
    }
}
