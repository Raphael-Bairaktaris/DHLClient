namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Arguments used for reference data
    /// </summary>
    public class ReferenceDataAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Must provide at least one datasetName value. If providing just the datasetName with no 
        /// filterBy fields - the response will return the entire data set from the dataset table (bulk).
        /// </summary>
        [ArgumentName("datasetName")]
        public DataSetType? DataSetName { get; set; }

        /// <summary>
        /// Use filter by value to query based on the specific string for optimized search.
        /// </summary>
        /// <example>dataset: filterByAttribute| supported filterByValue</example>
        [ArgumentName("filterByValue")]
        public string? FilterByValue { get; set; }

        /// <summary>
        /// Use filter by attribute to define the list of supported attributed for the specified datasetName.
        /// </summary>
        /// <example>dataset: supported filterByAttributes values</example>
        [ArgumentName("filterByAttribute")]
        public string? FilterByAttribute { get; set; }

        /// <summary>
        /// Use comparison operator to define the specific match condition for optimized search.
        /// </summary>
        [ArgumentName("comparisonOperator")]
        public ComparisonOperatorType? ComparisonOperator { get; set; }

        /// <summary>
        /// Use queryString for additional filter criteria in format of '[attribute]:[value]:[comparisonOperator]'.
        /// All additional filters are applied together with logical connector 'AND'.
        /// Maximum of three additional attribute-value-comparisonOperator combinations.
        /// Multiple queryString parameters will be separated by comma "," separator
        /// </summary>
        /// <example>queryString=operationName:shipment:equal</example>
        [ArgumentName("queryString")]
        public string? QueryString { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReferenceDataAPIArgs() : base()
        {

        }

        #endregion
    }
}
