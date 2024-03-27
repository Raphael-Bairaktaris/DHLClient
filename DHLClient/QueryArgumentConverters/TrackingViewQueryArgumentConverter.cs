using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used to for converting a <see cref="TrackingView"/> to a <see cref="string"/>
    /// </summary>
    public class TrackingViewQueryArgumentConverter : BaseQueryArgumentConverter<TrackingView>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackingViewQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(TrackingView value) => DHLClientConstants.TrackingViewToStringMapper[value];

        #endregion
    }
}
