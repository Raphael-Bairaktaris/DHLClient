using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    public class ServicePointLocationByAddressResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The `self` link relation - globally unique identifier of this DHL Service Point location.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// The location
        /// </summary>
        public IEnumerable<FindLocationResponseModel> Location { get; set; }

        /// <summary>
        /// Address to put on a label, to send a shipment to a service point or locker for pick up / drop off.
        /// For German locations, keyword and keywordId are placed as street name and house number, streetAddress
        /// is omitted on the label of a shipment. For locations outside of Germany, keyword and keywordId are placed in addition to streetAddress.
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// The id belonging to keyword that together with the keyword id build up the streetAddress for direct addressing to a service point or a locker for pick up / drop off.
        /// </summary>
        public string KeywordId { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByAddressResponseModel() : base()
        {

        }

        #endregion
    }
}
