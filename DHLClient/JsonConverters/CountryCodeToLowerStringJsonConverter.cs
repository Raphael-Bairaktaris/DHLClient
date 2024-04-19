using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that is used for converting a <see cref="CountryCode"/> to <see cref="string"/>
    /// </summary>
    public class CountryCodeToLowerStringJsonConverter : BaseEnumJsonConverter<CountryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CountryCodeToLowerStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CountryCode, string> GetMapper() => DHLClientConstants.CountryCodeToLowerStringMapper;

        #endregion
    }
}
