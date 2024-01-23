using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the line item reference types
    /// </summary>
    public enum LineItemReferenceType
    {
        /// <summary>
        /// Export Control Commodity Number (ECCN)
        /// </summary>
        AFE = 0,

        /// <summary>
        /// Brand
        /// </summary>
        BRD = 1,

        /// <summary>
        /// Dangerous Goods Content Identifier
        /// </summary>
        DGC = 2,

        /// <summary>
        /// Delivery Order Number
        /// </summary>
        AAJ = 3,

        /// <summary>
        /// In Bond Shipment
        /// </summary>
        INB = 4,

        /// <summary>
        /// Make
        /// </summary>
        MAK = 5,

        /// <summary>
        /// Model
        /// </summary>
        ALX = 6,

        /// <summary>
        /// Part No
        /// </summary>
        PAN = 7,

        /// <summary>
        /// Purchase Order Number
        /// </summary>
        PON = 8,

        /// <summary>
        /// Stock Keeping Unit
        /// </summary>
        ABW = 9,

        /// <summary>
        /// Serial Number
        /// </summary>
        SE = 10,

        /// <summary>
        /// Sales Order No
        /// </summary>
        SON = 11,

        /// <summary>
        /// Order Id
        /// </summary>
        OID = 12,

        /// <summary>
        /// DDTC Eligibility indicator
        /// </summary>
        DTC = 13,

        /// <summary>
        /// DDTC UOM
        /// </summary>
        DTM = 14,

        /// <summary>
        /// DDTC Quantity
        /// </summary>
        DTQ = 15,

        /// <summary>
        /// DDTC Registration No
        /// </summary>
        DTR = 16,

        /// <summary>
        /// DDTC ITAR Exemption No
        /// </summary>
        ITR = 17,

        /// <summary>
        /// Manufacturers Identification code
        /// </summary>
        MID = 18,

        /// <summary>
        /// Original Export Date
        /// </summary>
        OED = 19,

        /// <summary>
        /// Original Export OB Tracking ID
        /// </summary>
        OET = 20,

        /// <summary>
        /// Original Outbound Carrier
        /// </summary>
        OOR = 21,

        /// <summary>
        /// SME Indicator
        /// </summary>
        SME = 22,

        /// <summary>
        /// USM Category Code
        /// </summary>
        USM = 23,

        /// <summary>
        /// AAM Ref#
        /// </summary>
        AAM = 24,

        /// <summary>
        /// Licence Exemption (CFR)
        /// </summary>
        CFR = 25,

        /// <summary>
        /// Domestic Indicator (US)
        /// </summary>
        DOM = 26,

        /// <summary>
        /// Foreign Indicator CoO (US)
        /// </summary>
        FOR = 27,

        /// <summary>
        /// Usage
        /// </summary>
        USG = 28,

        /// <summary>
        /// Material
        /// </summary>
        MAT = 29,

        /// <summary>
        /// No Licence Required
        /// </summary>
        NLR = 30
    }
}
