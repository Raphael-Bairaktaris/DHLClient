using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that is used for converting a <see cref="FourLetterLanguageScript"/> to <see cref="string"/>
    /// </summary>
    public class FourLetterLanguageScriptToStringJsonConverter : BaseEnumJsonConverter<FourLetterLanguageScript>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FourLetterLanguageScriptToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FourLetterLanguageScript, string> GetMapper() => DHLClientConstants.FourLetterLanguageScriptToStringMapper;

        #endregion
    }
}
