using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="CountryCode"/> to <see cref="string"/>
    /// </summary>
    public class CountryCodeQueryArgymentConverter : BaseQueryArgumentConverter<CountryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CountryCodeQueryArgymentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(CountryCode value) => DHLClientConstants.CountryCodeToStringMapper[value];

        #endregion
    }
}
