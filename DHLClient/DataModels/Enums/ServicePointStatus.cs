using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the service point status types
    /// </summary>
    public enum ServicePointStatus
    {
        /// <summary>
        /// Service Available (Open)
        /// </summary>
        A = 0,
        
        /// <summary>
        /// Service Suspended (Temporarily Closed)
        /// </summary>
        S = 1,

        /// <summary>
        /// Service Unavailable (Temporarily Closed)
        /// </summary>
        U = 2,

        /// <summary>
        /// Closed (Temporarily Closed)
        /// </summary>
        X = 3,

        /// <summary>
        /// Not Yet Open (Temporarily Closed)
        /// </summary>
        Y = 4
    }
}
