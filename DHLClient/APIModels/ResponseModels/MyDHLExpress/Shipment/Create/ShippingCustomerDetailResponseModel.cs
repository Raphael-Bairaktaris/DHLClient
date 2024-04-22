﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// The base for all the shipping details
    /// </summary>
    public class ShippingCustomerDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ShipperDetails"/> property
        /// </summary>
        private ShippingEntityResponseModel? mShipperDetails;

        /// <summary>
        /// The member of the <see cref="ReceiverDetails"/> property
        /// </summary>
        private ShippingEntityResponseModel? mReceiverDetails;

        #region Public Properties

        /// <summary>
        /// The shipper details
        /// </summary>
        [JsonProperty("shipperDetails")]
        public ShippingEntityResponseModel ShipperDetails 
        { 
            get => mShipperDetails ??= new ShippingEntityResponseModel();
            set => mShipperDetails = value;
        }

        /// <summary>
        /// The receiver details
        /// </summary>
        [JsonProperty("receiverDetails")]
        public ShippingEntityResponseModel ReceiverDetails 
        { 
            get => mReceiverDetails ??= new ShippingEntityResponseModel();
            set => mReceiverDetails = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShippingCustomerDetailResponseModel() : base()
        {

        }

        #endregion
    }
}
