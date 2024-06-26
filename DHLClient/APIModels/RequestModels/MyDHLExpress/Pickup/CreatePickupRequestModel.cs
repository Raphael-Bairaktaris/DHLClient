﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a pickup
    /// </summary>
    public class CreatePickupRequestModel
    {
        #region Public Properties

        // <summary>
        /// Identifies the date and time the package is ready for pickup Both the date and time portions of the string are expected to be used. 
        /// The date should not be a past date or a date more than 10 days in the future. The time is the local time of the shipment based on the shipper's time zone. 
        /// The date component must be in the format: YYYY-MM-DD; the time component must be in the format: HH:MM:SS using a 24 hour clock. The date and time parts are separated by the letter T
        /// </summary>
        /// <example>2019-08-04T14:00:31GMT+01:00</example>
        [JsonRequired]
        [JsonProperty("plannedPickupDateAndTime")]
        [JsonConverter(typeof(DateTimeOffsetWithGMTPrefixToStringJsonConverter))]
        public DateTimeOffset? PlannedPickupDateAndTime { get; set; }

        /// <summary>
        /// The latest time the location premises is available to dispatch the DHL Express shipment. (HH:MM)
        /// </summary>
        /// <example>18:00</example>
        [JsonProperty("closeTime")]
        [JsonConverter(typeof(TimeOnlyToStringJsonConverter))]
        public TimeOnly? CloseTime { get; set; }

        /// <summary>
        /// Provides information on where the package should be picked up by DHL courier.
        /// </summary>
        /// <example>reception</example>
        [JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Provides information on where the package should be picked up by DHL courier.
        /// </summary>
        /// <example>residence</example>
        [JsonRequired]
        [JsonProperty("locationType")]
        [JsonConverter(typeof(PickupLocationToStringJsonConverter))]
        public PickupLocation LocationType { get; set; }

        /// <summary>
        /// The accounts
        /// </summary>
        [JsonRequired]
        [JsonProperty("accounts")]
        public IEnumerable<AccountRequestModel>? Accounts { get; set; }

        /// <summary>
        /// Please provide updated details related to shipment you want update the pickup for
        /// </summary>
        [JsonProperty("specialInstructions")]
        public IEnumerable<ShipmentSpecialInstructionRequestModel>? SpecialInstructions { get; set; }

        /// <summary>
        /// Please provide additional pickup remark
        /// </summary>
        [JsonProperty("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// The customer details
        /// </summary>
        [JsonRequired]
        [JsonProperty("customerDetails")]
        public ReceiverDetailsRequestModel? CustomerDetails { get; set; }

        /// <summary>
        /// The pickup details
        /// </summary>
        [JsonProperty("pickupDetails")]
        public BookingRequestorDetailRequestModel? PickupDetails { get; set; }

        /// <summary>
        /// The shipment details
        /// </summary>
        [JsonProperty("shipmentDetails")]
        public IEnumerable<PickupShipmentDetailRequestModel>? ShipmentDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreatePickupRequestModel() : base()
        {

        }

        #endregion
    }
}
