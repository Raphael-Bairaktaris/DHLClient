using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient.DataModels.Enums
{
    /// <summary>
    /// Provides enumeration over the level of detail types
    /// </summary>
    public enum LevelOfDetail
    {
        /// <summary>
        /// Shipment
        /// </summary>
        Shipment = 0,

        /// <summary>
        /// Piece
        /// </summary>
        Piece = 1,

        /// <summary>
        /// All
        /// </summary>
        All = 2
    }
}
