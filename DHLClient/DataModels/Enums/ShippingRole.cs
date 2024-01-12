﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the shipping role
    /// </summary>
    public enum ShippingRole
    {
        /// <summary>
        /// Shipper
        /// </summary>
        Shipper = 0,

        /// <summary>
        /// Payer
        /// </summary>
        Payer = 1,

        /// <summary>
        /// Duties-Taxes
        /// </summary>
        DutiesTaxes = 2
    }
}
