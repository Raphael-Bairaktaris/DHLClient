using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert an <see cref="IdentifierType"/> to <see cref="string"/>
    /// </summary>
    public class IdentifierTypeQueryArgumentConverter : BaseQueryArgumentConverter<IdentifierType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IdentifierTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(IdentifierType value) => DHLClientConstants.IdentifierTypeToStringMapper[value];

        #endregion
    }
}
