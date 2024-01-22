namespace DHLClient
{
    /// <summary>
    /// Requests used for pickup customer details
    /// </summary>
    public class PickupCustomerDetailRequestModel : CustomerDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The booking requestor details
        /// </summary>
        public BookingRequestorDetailRequestModel BookingRequestorDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PickupCustomerDetailRequestModel() : base()
        {

        }

        #endregion
    }
}