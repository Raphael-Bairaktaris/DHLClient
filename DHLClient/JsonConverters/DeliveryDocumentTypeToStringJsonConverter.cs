using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="DeliveryDocumentType"/> to <see cref="string"/>
    /// </summary>
    public class DeliveryDocumentTypeToStringJsonConverter : BaseEnumJsonConverter<DeliveryDocumentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryDocumentTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DeliveryDocumentType, string> GetMapper() => DHLClientConstants.DeliveryDocumentTypeToStringMapper;

        #endregion
    }
}
