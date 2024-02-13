using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the shipment attributes
    /// </summary>
    public enum ShipmentAttribute
    {
        /// <summary>
        /// Parent id
        /// </summary>
        ParentId = 0,

        /// <summary>
        /// Shipment id
        /// </summary>
        ShipmentId = 1,

        /// <summary>
        /// Piece id
        /// </summary>
        PieceId = 2
    }
}
