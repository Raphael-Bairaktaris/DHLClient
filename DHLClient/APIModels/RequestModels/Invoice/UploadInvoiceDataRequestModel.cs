﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Requests used for uploading an invoice
    /// </summary>
    public class UploadInvoiceDataRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide Shipment Identification number (AWB number)
        /// </summary>
        /// <example>123456790</example>
        [JsonProperty("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The planned shipment date for the provided shipmentTrackingNumber. 
        /// The date must be in the format: YYYY-MM-DD
        /// </summary>
        [JsonProperty("plannedShipDate")]
        public DateOnly PlannedShipDate { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment. 
        /// Note: accounts/0/number with typeCode 'shipper' is mandatory if using POST method and no shipmentTrackingNumber is provided in request.
        /// </summary>
        [JsonProperty("accounts")]
        public AccountRequestModel? Accounts { get; set; }

        /// <summary>
        /// Here you can define all the properties related to the content of the prospected shipment
        /// </summary>
        [JsonRequired]
        [JsonProperty("content")]
        public ShipmentContentRequestModel Content { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadInvoiceDataRequestModel() : base()
        {

        }

        #endregion
    }
}
