namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the document types
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// Invoice
        /// </summary>
        INV = 0,

        /// <summary>
        /// Proforma
        /// </summary>
        PNV = 1,

        /// <summary>
        /// Certificate Of Origin
        /// </summary>
        COO = 2,

        /// <summary>
        /// Commercial Invoice
        /// </summary>
        CIN = 3,

        /// <summary>
        /// Custom Declaration
        /// </summary>
        DCL = 4,

        /// <summary>
        /// Air Waybill and Waybill Document
        /// </summary>
        AWB = 5,

        /// <summary>
        /// Nafta Certificate of Origin
        /// </summary>
        NAF = 6
    }
}
