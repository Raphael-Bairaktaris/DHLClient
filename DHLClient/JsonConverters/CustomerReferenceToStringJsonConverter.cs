using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="CustomerReference"/> to <see cref="string"/>
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
