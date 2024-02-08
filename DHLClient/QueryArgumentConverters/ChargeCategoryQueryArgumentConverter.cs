using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="ChargeCategory"/> to a <see cref="string"/>
    /// </summary>
    public class ChargeCategoryQueryArgumentConverter : BaseQueryArgumentConverter<ChargeCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChargeCategoryQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ChargeCategory value) => DHLClientConstants.ChargeCategoryToStringMapper[value];

        #endregion
    }
}
