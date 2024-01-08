using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment origin address response
    /// </summary>
    public class ShipmentLocationAddressResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PostalCode"/> property
        /// </summary>
        private string? mPostalCode;

        /// <summary>
        /// The member of the <see cref="AddressLocality"/> property
        /// </summary>
        private string? mAddressLocality;

        /// <summary>
        /// The member of the <see cref="StreetAddress"/> property
        /// </summary>
        private string? mStreetAddress;

        #endregion

        #region Public Properties

        /// <summary>
        /// The country code
        /// </summary>
        [JsonProperty("countryCode")]
        public CountryCodeType CountryCode { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode 
        { 
            get => mPostalCode ?? string.Empty;
            set => mPostalCode = value;
        }

        /// <summary>
        /// The address locality
        /// </summary>
        [JsonProperty("addressLocality")]
        public string AddressLocality 
        { 
            get => mAddressLocality ?? string.Empty;
            set => mAddressLocality = value;
        }

        /// <summary>
        /// the street address
        /// </summary>
        [JsonProperty("streetAddress")]
        public string StreetAddress 
        { 
            get => mStreetAddress ?? string.Empty;
            set => mStreetAddress = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentLocationAddressResponseModel() : base()
        {

        }

        #endregion
    }
}
