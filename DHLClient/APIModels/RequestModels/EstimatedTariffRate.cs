namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the estimated tariff rate types
    /// </summary>
    public enum EstimatedTariffRate
    {
        /// <summary>
        /// Default rate 
        /// </summary>
        DefaultRate = 0,

        /// <summary>
        /// Derived rate
        /// </summary>
        DerivedRate = 1,

        /// <summary>
        /// Highest rate
        /// </summary>
        HighestRate = 2,

        /// <summary>
        /// Center rate
        /// </summary>
        CenterRate = 3,
        
        /// <summary>
        /// Lowest rate
        /// </summary>
        LowestRate = 4
    }
}