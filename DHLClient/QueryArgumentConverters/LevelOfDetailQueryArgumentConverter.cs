using DHLClient.DataModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="LevelOfDetail"/> to a <see cref="string"/>
    /// </summary>
    public class LevelOfDetailQueryArgumentConverter : BaseQueryArgumentConverter<LevelOfDetail>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LevelOfDetailQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(LevelOfDetail value) => DHLClientConstants.LevelOfDetailToStringMapper[value];

        #endregion
    }
}
