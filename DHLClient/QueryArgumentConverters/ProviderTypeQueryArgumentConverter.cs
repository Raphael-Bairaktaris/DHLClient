using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumEnumerableJsonConverter{T}"/> that is used for converting a <see cref="ProviderType"/> to a <see cref="string"/>
    /// </summary>
    public class ProviderTypeQueryArgumentConverter : BaseQueryArgumentConverter<ProviderType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProviderTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ProviderType value) => DHLClientConstants.ProviderTypeToStringMapper[value];

        #endregion
    }
}
