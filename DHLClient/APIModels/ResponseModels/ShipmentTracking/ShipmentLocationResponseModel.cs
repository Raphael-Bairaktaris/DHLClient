using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment origin response
    /// </summary>
    public class ShipmentLocationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private IEnumerable<string>? mAddress;

        #endregion

        #region Public Properties

        /// <summary>
        /// The address
        /// </summary>
        public IEnumerable<string> Address 
        { 
            get => mAddress ?? Enumerable.Empty<string>();
            set => mAddress = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentLocationResponseModel() : base()
        {

        }

        #endregion
    }
}
