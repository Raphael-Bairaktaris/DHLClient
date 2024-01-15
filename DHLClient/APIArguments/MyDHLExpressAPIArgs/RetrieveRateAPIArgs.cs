using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Arguments used for retrieving rate
    /// </summary>
    public class RetrieveRateAPIArgs : LandedCostAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// If set to true, indicate strict DCT validation of address details, and validation of product and service(s) combination provided in request.
        /// </summary>
        [ArgumentName("strictValidation")]
        public bool ShouldStrictValidation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RetrieveRateAPIArgs() : base()
        {

        } 

        #endregion
    }
}
