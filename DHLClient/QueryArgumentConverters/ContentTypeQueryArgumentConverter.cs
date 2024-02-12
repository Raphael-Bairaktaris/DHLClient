using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that converts a <see cref="ContentType"/> to <see cref="string"/>
    /// </summary>
    public class ContentTypeQueryArgumentConverter : BaseQueryArgumentConverter<ContentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ContentTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ContentType value) => DHLClientConstants.ContentTypeToStringMapper[value];

        #endregion
    }
}
