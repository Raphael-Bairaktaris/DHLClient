using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment
    /// </summary>
    public class CreateShipmentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Identifies the date and time the package is tendered. Both the date and time portions of the string are expected to be used. The date should not be a past date or a
        /// date more than 10 days in the future. The time is the local time of the shipment based on the shipper's time zone. The date component must be in the format: YYYY-MM-DD; 
        /// the time component must be in the format: HH:MM:SS using a 24 hour clock. The date and time parts are separated by the letter T
        /// </summary>
        /// <example>2006-06-26T17:00:00 GMT+01:00</example>
        [JsonRequired]
        [JsonProperty("plannedShippingDateAndTime")]
        public DateTimeOffset PlannedShippingDatimeAndTime { get; set; }

        /// <summary>
        /// The pickup
        /// </summary>
        [JsonRequired]
        [JsonProperty("pickup")]
        public ShipmentPickupRequestModel? Pickup { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateShipmentRequestModel() : base()
        {

        }

        #endregion
    }
}
