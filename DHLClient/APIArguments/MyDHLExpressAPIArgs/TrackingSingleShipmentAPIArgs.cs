using DHLClient.DataModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Arguments used tracking a single shipment
    /// </summary>
    public class TrackingSingleShipmentAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        [ArgumentName("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The tracking view
        /// </summary>
        [ArgumentName("trackingView")]
        public TrackingView TrackingView { get; set; }

        /// <summary>
        /// The level of detail tracking
        /// </summary>
        [ArgumentName("levelOfDetail")]
        public LevelOfDetail LevelOfDetail { get; set; }

        public 

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackingSingleShipmentAPIArgs() : base()
        {

        }

        #endregion
    }
}
