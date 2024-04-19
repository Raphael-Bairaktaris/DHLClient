namespace DHLClient
{
    /// <summary>
    /// The Rate request will return DHL's product capabilities and prices (where applicable) based on the input data. 
    /// Using the shipper and receiver address as well as the dimension and weights of the pieces belonging to a shipment, 
    /// this operation returns the available products including the shipping price (where applicable)
    /// </summary>
    public class MultiShipmentRateRetrievalResponseModel : BaseRatingRetrievalResponseModel
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MultiShipmentRateRetrievalResponseModel() : base()
        {

        }

        #endregion
    }
}
