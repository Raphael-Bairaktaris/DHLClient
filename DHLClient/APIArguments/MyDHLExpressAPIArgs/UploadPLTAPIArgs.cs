﻿namespace DHLClient
{
    /// <summary>
    /// Arguments used for uploading a paperless trade
    /// </summary>
    public class UploadPLTAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        /// <example>9356579890</example>
        [ArgumentName("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadPLTAPIArgs() : base()
        {

        }

        #endregion    
    }
}