using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the shipping options
    /// </summary>
    public enum ShippingOption
    {
        /// <summary>
        /// Bulky
        /// </summary>
        Bulky = 0,

        /// <summary>
        /// Pickup
        /// </summary>
        Pickup = 1,

        /// <summary>
        /// Go green
        /// </summary>
        GoGreen = 2,

        /// <summary>
        /// Priority
        /// </summary>
        Priority = 3,

        /// <summary>
        /// Extra insurance
        /// </summary>
        ExtraInsurance = 4,

        /// <summary>
        /// Direct injection
        /// </summary>
        DirectInjection = 5,

        /// <summary>
        /// Cash on delivery
        /// </summary>
        CashOnDelivery = 6
    }
}
