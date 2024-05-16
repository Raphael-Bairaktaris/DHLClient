namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// The Rate request will return DHL's product capabilities and prices (where applicable) based on the input data. 
    /// Using the shipper and receiver address as well as the dimension and weights of the pieces belonging to a shipment, 
    /// this operation returns the available products including the shipping price (where applicable)
    /// </summary>
    public class SingleShipmentRateRetrievalResponseModel : BaseRatingRetrievalResponseModel
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SingleShipmentRateRetrievalResponseModel() : base()
        {

        }

        #endregion
    }
}
