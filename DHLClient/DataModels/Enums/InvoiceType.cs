﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the invoice types
    /// </summary>
    public enum InvoiceType
    {
        /// <summary>
        /// Commercial
        /// </summary>
        Commercial = 0,

        /// <summary>
        /// Proforma
        /// </summary>
        Proforma = 1,

        /// <summary>
        /// Returns
        /// </summary>
        Returns = 2
    }
}
