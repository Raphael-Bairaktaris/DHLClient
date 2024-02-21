using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert a <see cref="DeliveryService"/> to <see cref="string"/>
    /// </summary>
    public class DeliveryServiceQueryArgumentConverter : BaseQueryArgumentConverter<DeliveryService>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryServiceQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(DeliveryService value) => DHLClientConstants.DeliveryServiceToStringMapper[value];

        #endregion
    }
}
