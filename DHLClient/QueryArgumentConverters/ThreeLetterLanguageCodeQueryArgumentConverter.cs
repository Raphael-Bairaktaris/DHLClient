using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert a <see cref="ThreeLetterLanguageCode"/> to <see cref="string"/> 
    /// </summary>
    public class ThreeLetterLanguageCodeQueryArgumentConverter : BaseQueryArgumentConverter<ThreeLetterLanguageCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ThreeLetterLanguageCodeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ThreeLetterLanguageCode value) => DHLClientConstants.ThreeLetterLanguageCodeToStringMapper[value];

        #endregion
    }
}
