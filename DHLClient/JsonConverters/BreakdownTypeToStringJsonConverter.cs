using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that is used to convert a <see cref="BreakdownType"/> to <see cref="string"/>
    /// </summary>
    public class BreakdownTypeToStringJsonConverter : BaseEnumJsonConverter<BreakdownType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BreakdownTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BreakdownType, string> GetMapper() => DHLClientConstants.BreakdownTypeToStringMapper;

        #endregion
    }
}
