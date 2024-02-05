namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the document types
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// Invoice (INV)
        /// </summary>
        Invoice = 0,

        /// <summary>
        /// Proforma (PNV)
        /// </summary>
        Proforma = 1,

        /// <summary>
        /// Certificate Of Origin (COO)
        /// </summary>
        CertificateOfOrigin = 2,

        /// <summary>
        /// Commercial Invoice (CIN)
        /// </summary>
        CommercialInvoice = 3,

        /// <summary>
        /// Custom Declaration (DCL)
        /// </summary>
        CustomDeclaration = 4,

        /// <summary>
        /// Air Waybill and Waybill Document (AWB)
        /// </summary>
        AirWaybillAndWaybillDocument = 5,

        /// <summary>
        /// Nafta Certificate of Origin (NAF)
        /// </summary>
        NaftaCertificateOfOrigin = 6
    }
}
