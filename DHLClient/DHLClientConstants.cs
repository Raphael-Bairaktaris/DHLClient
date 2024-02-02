using DHLClient.DataModels.Enums;
using System.Collections.Immutable;

namespace DHLClient
{
    /// <summary>
    /// Constants related to the DHL client
    /// </summary>
    public static class DHLClientConstants
    {
        /// <summary>
        /// Maps the <see cref="BusinessPartyType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<BusinessPartyType, string> BusinessPartyTypeToStringMapper { get; } = new Dictionary<BusinessPartyType, string>()
        {
            { BusinessPartyType.Business, "business" },
            { BusinessPartyType.DirectConsumer, "direct_consumer" },
            { BusinessPartyType.Government, "government" },
            { BusinessPartyType.Other, "other"},
            { BusinessPartyType.Private, "private" },
            { BusinessPartyType.Reseller, "reseller" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CapacityType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CapacityType, string> CapacityTypeToStringMapper { get; } = new Dictionary<CapacityType, string>()
        {
            { CapacityType.High, "high" },
            { CapacityType.Low, "low" },
            { CapacityType.VeryLow, "veryLow" },
            { CapacityType.Unknown, "unknown" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CargoType"/>s to their proper <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CargoType, string> CargoTypeToStringMapper { get; } = new Dictionary<CargoType, string>()
        {
            { CargoType.Freight, "freight" },
            { CargoType.Insurance, "insurance" },
            { CargoType.Addtional, "additional" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CarrierName"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CarrierName, string> CarrierNameToStringMapper { get; } = new Dictionary<CarrierName, string>()
        {
            { CarrierName.DHL, "dhl" },
            { CarrierName.UPS, "ups" },
            { CarrierName.FEDEX, "fedex" },
            { CarrierName.TNT, "tnt" },
            { CarrierName.POST, "post" },
            { CarrierName.OTHERS, "others" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ChargeCategory"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ChargeCategory, string> ChargeCategoryToStringMapper { get; } = new Dictionary<ChargeCategory, string>()
        {
            { ChargeCategory.TAX, "tax" },
            { ChargeCategory.FEE, "fee" },
            { ChargeCategory.DUTY, "duty" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ChargeType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ChargeType, string> ChargeTypeToStringMapper { get; } = new Dictionary<ChargeType, string>()
        {
            { ChargeType.Admin, "admin" },
            { ChargeType.Delivery, "delivery" },
            { ChargeType.Documentation, "documentation" },
            { ChargeType.Expedite, "expedite" },
            { ChargeType.Export, "export" },
            { ChargeType.Freight, "freight" },
            { ChargeType.FuelSurcharge, "fuel_surcharge" },
            { ChargeType.Logistic, "logistic" },
            { ChargeType.Other, "other" },
            { ChargeType.Packaging, "packaging" },
            { ChargeType.Pickup, "pickup" },
            { ChargeType.Handling, "handling" },
            { ChargeType.Vat, "vat" },
            { ChargeType.Insurance, "insurance" },
            { ChargeType.ReverseCharge, "reverse_charge" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CommodityCode"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CommodityCode, string> CommodityCodeToStringMapper { get; } = new Dictionary<CommodityCode, string>()
        {
            { CommodityCode.DerivedRate, "derived_rate" },
            { CommodityCode.HighestRate, "highest_rate" },
            { CommodityCode.LowestRate, "lowest_rate" },
            { CommodityCode.CenterRate, "center_rate" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CommodityCodeType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CommodityCodeType, string> CommodityCodeTypeToStringMapper { get; } = new Dictionary<CommodityCodeType, string>()
        {
            { CommodityCodeType.Outbound, "outbound" },
            { CommodityCodeType.Inbound, "inbound" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ComparisonOperatorType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ComparisonOperatorType, string> ComparisonOperatorTypeToStringMapper { get; } = new Dictionary<ComparisonOperatorType, string>()
        {
            { ComparisonOperatorType.Equal, "equal" },
            { ComparisonOperatorType.NotEqual, "notEqual" },
            { ComparisonOperatorType.Contains, "contains" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ContentType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ContentType, string> ContentTypeToStringMapper { get; } = new Dictionary<ContentType, string>()
        {
            { ContentType.EpodDetail, "epod-detail" },
            { ContentType.EpodSummary, "epod-summary" },
            { ContentType.EpodDetailEsig, "epod-detail-esig" },
            { ContentType.EpodSummaryEsig, "epod-summary-esig" },
            { ContentType.EpodTable, "epod-table" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CustomsDocumentType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CustomsDocumentType, string> CustomsDocumentTypeToStringMapper { get; } = new Dictionary<CustomsDocumentType, string>()
        {
            { CustomsDocumentType.DispensePaymentDroits, "972" },
            { CustomsDocumentType.AnalysisAndHealthCertificate, "AHC" },
            { CustomsDocumentType.AgriculturalLicense, "ALC" },
            { CustomsDocumentType.ATACarnet, "ATA" },
            { CustomsDocumentType.PreferenceCertificateATR, "ATR" },
            { CustomsDocumentType.BranchLetterOfExemption, "BEX" },
            { CustomsDocumentType.PowerOfAttorney, "CHA" },
            { CustomsDocumentType.CommonHealthEntryDocument, "CHD" },
            { CustomsDocumentType.CommonHealthEntryDocumentForProducts, "CHP" },
            { CustomsDocumentType.CitesCertificate, "CIT" },
            { CustomsDocumentType.CustomsInvoiceValue, "CIV" },
            { CustomsDocumentType.ExportOnlyInvoice, "CI2" },
            { CustomsDocumentType.GenericCertificateOfOrigin, "COO" },
            { CustomsDocumentType.ConsigneePowerOfAttorney, "CPA" },
            { CustomsDocumentType.ControlDocument, "CRL" },
            { CustomsDocumentType.ConsolidatedCustomsEntry, "CSD" },
            { CustomsDocumentType.DutyExemptionCertificate, "DEX" },
            { CustomsDocumentType.DagerousGoodsDeclaration, "DGD" },
            { CustomsDocumentType.DriverLicence, "DLI" },
            { CustomsDocumentType.Invoice, "DOV" },
            { CustomsDocumentType.ExportLicensesAndPermits, "ELP" },
            { CustomsDocumentType.PreferenceCertificateEUR1, "EU1" },
            { CustomsDocumentType.PreferentialDeclarationOfOriginOnTheInvoiceEUR2, "EU2" },
            { CustomsDocumentType.EndOfAuthorization, "EUS" },
            { CustomsDocumentType.DCEExportOfCustomsData, "EXL" },
            { CustomsDocumentType.CertificateOfOrigin, "FMA" },
            { CustomsDocumentType.HealethProductsRegulatoryAuthorityLicensingRequirements, "HLC" },
            { CustomsDocumentType.HouseWaybill, "HWB" },
            { CustomsDocumentType.CommercialInvoice, "INV" },
            { CustomsDocumentType.IntellectualPropertyAuthorization, "IPA" },
            { CustomsDocumentType.JusticeLicence, "JLC" },
            { CustomsDocumentType.SpecificExportLicences, "LIC" },
            { CustomsDocumentType.LicenceOfPermit, "LNP" },
            { CustomsDocumentType.NationalIdentityCard, "NID" },
            { CustomsDocumentType.Passport, "PAS" },
            { CustomsDocumentType.ProForma, "PFI" },
            { CustomsDocumentType.PhytosanitaryCertificate, "PHY" },
            { CustomsDocumentType.PermitsAndLicenses, "PLI" },
            { CustomsDocumentType.PowerOfAttorneyCustomerBased, "POA" },
            { CustomsDocumentType.ProofOfPayment, "PPY" },
            { CustomsDocumentType.ReceiptOnDelivery, "ROD" },
            { CustomsDocumentType.TransportAccompanyingDocument, "T2M" },
            { CustomsDocumentType.TransportAccompanyingDocumentT1, "TAD" },
            { CustomsDocumentType.TransportationChargesStatement, "TCS" },
            { CustomsDocumentType.VeterinaryEntryDocument, "VET" },
            { CustomsDocumentType.VATExemptionCertificate, "VEX" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DataSetType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DataSetType, string> DataSetTypeToStringMapper { get; } = new Dictionary<DataSetType, string>()
        {
            { DataSetType.Country, "country" },
            { DataSetType.CountryPostalCodeFormat, "countryPostalcodeFormat" },
            { DataSetType.DangerousGoods, "dangerousGoods" },
            { DataSetType.Incoterm, "incoterm" },
            { DataSetType.ProductCode, "productCode" },
            { DataSetType.ServiceCode, "serviceCode" },
            { DataSetType.PackageTypeCode, "packageTypeCode" },
            { DataSetType.DocumentTypeCode, "documentTypeCode" },
            { DataSetType.CustomerShipmentReferenceType, "customerShipmentReferenceType" },
            { DataSetType.CustomerPackageReferenceType, "customerPackageReferenceType" },
            { DataSetType.InvoiceReferenceType, "invoiceReferenceType" },
            { DataSetType.InvoiceItemReferenceType, "invoiceItemReferenceType" },
            { DataSetType.RegistrationNumberTypeCode, "registrationNumberTypeCode" },
            { DataSetType.CommodityCategory, "commodityCategory" },
            { DataSetType.ReturnStatusMessage, "returnStatusMessage" },
            { DataSetType.TrackingEventCode, "trackingEventCode" },
            { DataSetType.UnitOfMeasurement, "unitOfMeasurement" },
            { DataSetType.All, "all" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DeliveryOption"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DeliveryOption, string> DeliveryOptionToStringMapper { get; } = new Dictionary<DeliveryOption, string>()
        {
            { DeliveryOption.Delivery, "delivery" },
            { DeliveryOption.Pickup, "pickup" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DeliveryType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DeliveryType, string> DeliveryTypeToStringMapper { get; } = new Dictionary<DeliveryType, string>()
        {
            { DeliveryType.QDDC, "QDDC" },
            { DeliveryType.QDDF, "QDDF" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DestinationProvider"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DestinationProvider, string> DestinationProviderToStringMapper { get; } = new Dictionary<DestinationProvider, string>()
        {
            { DestinationProvider.ACSCourier, "acs-courier" },
            { DestinationProvider.Anpost, "anpost" },
            { DestinationProvider.Bpost, "bpost" },
            { DestinationProvider.Bring, "bring" },
            { DestinationProvider.Chronopost, "chronopost" },
            { DestinationProvider.ColisPrive, "colis-prive" },
            { DestinationProvider.Econnect, "econnect" },
            { DestinationProvider.Express, "express" },
            { DestinationProvider.Fastway, "fastway" },
            { DestinationProvider.Freight, "freight" },
            { DestinationProvider.FreightFR, "freight-fr" },
            { DestinationProvider.FreightSE, "freight-se" },
            { DestinationProvider.HrvatskaPosta, "hrvatska-posta" },
            { DestinationProvider.MagyarPosta, "magyar-posta" },
            { DestinationProvider.Oepag, "oepag" },
            { DestinationProvider.ParcelBE, "parcel-be" },
            { DestinationProvider.ParcelBL, "parcel-bl" },
            { DestinationProvider.ParcelCZ, "parcel-cz" },
            { DestinationProvider.ParcelDE, "parcel-de" },
            { DestinationProvider.ParcelES, "parcel-es" },
            { DestinationProvider.ParcelIberia, "parcel-iberia" },
            { DestinationProvider.ParcelLU, "parcel-lu" },
            { DestinationProvider.ParcelNL, "parcel-nl" },
            { DestinationProvider.ParcelPL, "parcel-pl" },
            { DestinationProvider.ParcelPT, "parcel-pt" },
            { DestinationProvider.ParcelUK, "parcel-uk" },
            { DestinationProvider.Posta, "posta" },
            { DestinationProvider.PostaSlovenije, "posta-sloveniije" },
            { DestinationProvider.Posti, "posti" },
            { DestinationProvider.PosteItaliane, "poste-italiane" },
            { DestinationProvider.PPL, "ppl" },
            { DestinationProvider.Rapido, "rapido" },
            { DestinationProvider.RelaisColis, "relais-colis" },
            { DestinationProvider.SlovakParcelService, "slovak-parcel-service" },
            { DestinationProvider.Speedy, "speedy" },
            { DestinationProvider.SPS, "sps" },
            { DestinationProvider.TransOFlex, "trans-o-flex" },
            { DestinationProvider.UrgentCargus, "urgent-cargus" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DHLDayOfWeek"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DHLDayOfWeek, string> DayOfWeekTypeToStringMapper { get; } = new Dictionary<DHLDayOfWeek, string>()
        {
            { DHLDayOfWeek.Monday, "monday" },
            { DHLDayOfWeek.Tuesday, "tuesday" },
            { DHLDayOfWeek.Wednesday, "wednesday" },
            { DHLDayOfWeek.Thursday, "thursday" },
            { DHLDayOfWeek.Friday, "friday" },
            { DHLDayOfWeek.Saturday, "saturday" },
            { DHLDayOfWeek.Sunday, "sunday" },
            { DHLDayOfWeek.PublicHolidays, "publicHolidays" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DimensionUnit"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DimensionUnit, string> DimensionUnitToStringMapper { get; } = new Dictionary<DimensionUnit, string>()
        {
            { DimensionUnit.Inches, "in" },
            { DimensionUnit.Centimeters, "cm" }
        };

        /// <summary>
        /// Maps the <see cref="DistanceUnit"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DistanceUnit, string> DistanceUnitToStringMapper { get; } = new Dictionary<DistanceUnit, string>()
        {
            { DistanceUnit.Miles, "mi" },
            { DistanceUnit.Kilometers, "km" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="DocumentInvoiceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DocumentInvoiceType, string> DocumentInvoiceTypeToStringMapper { get; } = new Dictionary<DocumentInvoiceType, string>()
        {
            { DocumentInvoiceType.Waybill, "waybill" },
            { DocumentInvoiceType.CommercialInvoice, "commercial-invoice" },
            { DocumentInvoiceType.CustomsEntry, "customs-entry" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="EncodingFormat"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<EncodingFormat, string> EncodingFormatToStringMapper { get; } = new Dictionary<EncodingFormat, string>()
        {
            { EncodingFormat.PDF, "pdf" },
            { EncodingFormat.ZPL, "zpl" },
            { EncodingFormat.LP2, "lp2" },
            { EncodingFormat.Tiff, "tiff" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ExportReason"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ExportReason, string> ExportReasonToStringMapper { get; } = new Dictionary<ExportReason, string>()
        {
            { ExportReason.Permanent, "permanent" },
            { ExportReason.Temporary, "temporary" },
            { ExportReason.Return, "return" },
            { ExportReason.UsedExhibitionGoodsToOrigin, "used_exhibition_goods_to_origin" },
            { ExportReason.CommercialPurposeOrSale, "commercial_purpose_or_sale" },
            { ExportReason.PersonalBelongingsOrPersonalUse, "personal_belongings_or_personal_use" },
            { ExportReason.Sample, "sample" },
            { ExportReason.Gift, "gift" },
            { ExportReason.ReturnToOrigin, "return_to_origin" },
            { ExportReason.WarrantyReplacement, "warranty_replacement" },
            { ExportReason.DiplomaticGoods, "diplomatic_goods" },
            { ExportReason.DefenceMaterial, "defence_material" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="FunctionType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<FunctionType, string> FunctionTypeToStringMapper { get; } = new Dictionary<FunctionType, string>()
        {
            { FunctionType.Import, "import" },
            { FunctionType.Export, "export" },
            { FunctionType.Both, "both" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="IdentifierType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<IdentifierType, string> IdentifierTypeToStringMapper { get; } = new Dictionary<IdentifierType, string>()
        {
            { IdentifierType.ShipmentId, "SID" },
            { IdentifierType.PID, "PID" },
            { IdentifierType.AdvanceShipmentOfThreeMonths, "ASID3" },
            { IdentifierType.AdvanceShipmentOfSixMonths, "ASID6" },
            { IdentifierType.AdvanceShipmentOfNineMonths, "ASID9" },
            { IdentifierType.AdvanceShipmentOfTwentyFourMonths, "ASID24" },
            { IdentifierType.HandlingUnitId, "HUID" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ImageFormat"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ImageFormat, string> ImageFormatToStringMapper { get; } = new Dictionary<ImageFormat, string>()
        {
            { ImageFormat.PDF, "pdf" },
            { ImageFormat.PNG, "png" },
            { ImageFormat.JPEG, "jpeg" },
            { ImageFormat.GIF, "gif" },
            { ImageFormat.TIFF, "tiff" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="Invoice"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<Invoice, string> InvoiceToStringMapper { get; } = new Dictionary<Invoice, string>()
        {
            { Invoice.Invoice, "invoice" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="IncotermRule"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<IncotermRule, string> IncotermRuleToStringMapper { get; } = new Dictionary<IncotermRule, string>()
        {
            {IncotermRule.ExWorks, "EXW" },
            {IncotermRule.FreeCarrier, "FCA" },
            {IncotermRule.CarriagePaidTo, "CPT" },
            {IncotermRule.CarriageAndInsurancePaidTo, "CIP" },
            {IncotermRule.DeliveredAtPlaceUnloaded, "DPU" },
            {IncotermRule.DeliveredAtPlace, "DAP" },
            {IncotermRule.DeliveryDutyPaid, "DDP" },
            {IncotermRule.FreeAlongsideShip, "FAS" },
            {IncotermRule.FreeOnBoard, "FOB" },
            {IncotermRule.CostAndFreight, "CFR" },
            {IncotermRule.CostInsuranceAndFreight, "CIF" },
            {IncotermRule.DeliveredAtFrontier, "DAF" },
            {IncotermRule.DeliveredAtTerminal, "DAT" },
            {IncotermRule.DeliveryDutyUnpaid, "DDU" },
            {IncotermRule.DeliveryExQuay, "DEQ" },
            {IncotermRule.DeliveredExShip, "DES" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="LevelOfDetail"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<LevelOfDetail, string> LevelOfDetailToStringMapper { get; } = new Dictionary<LevelOfDetail, string>()
        {
            { LevelOfDetail.All, "all" },
            { LevelOfDetail.Shipment, "shipment" },
            { LevelOfDetail.Piece, "piece" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="LineItemReferenceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<LineItemReferenceType, string> LineItemReferenceTypeToStringMapper { get; } = new Dictionary<LineItemReferenceType, string>()
        {
            { LineItemReferenceType.AFE, "AFE" },
            { LineItemReferenceType.Brand, "BRD" },
            { LineItemReferenceType.DangerousGoodsContentIdentifier, "DGC" },
            { LineItemReferenceType.DeliveryOrderNumber, "AAJ" },
            { LineItemReferenceType.InchesBondShipment, "INB" },
            { LineItemReferenceType.Make, "MAK" },
            { LineItemReferenceType.Model, "ALX" },
            { LineItemReferenceType.PartNo, "PAN" },
            { LineItemReferenceType.PurchaseOrderNumber, "PON" },
            { LineItemReferenceType.StockKeepingUnit, "ABW" },
            { LineItemReferenceType.SerialNumber, "SE" },
            { LineItemReferenceType.SalesOrderNo, "SON" },
            { LineItemReferenceType.OrderId, "OID" },
            { LineItemReferenceType.DTCEligibilityIndicator, "DTC" },
            { LineItemReferenceType.DTM, "DTM" },
            { LineItemReferenceType.DTQ, "DTQ" },
            { LineItemReferenceType.DTR, "DTR" },
            { LineItemReferenceType.ITARExemptionNo, "ITR" },
            { LineItemReferenceType.ManufacturersIdentificationCode, "MID" },
            { LineItemReferenceType.OriginalExportDate, "OED" },
            { LineItemReferenceType.OriginalExportTracikngId, "OET" },
            { LineItemReferenceType.OriginalOutboundCarrier, "OOR" },
            { LineItemReferenceType.SMEIndicator, "SME" },
            { LineItemReferenceType.USMCategoryCode, "USM" },
            { LineItemReferenceType.AAM, "AAM" },
            { LineItemReferenceType.LicenseExemption, "CFR" },
            { LineItemReferenceType.DomesticIndicator, "DOM" },
            { LineItemReferenceType.ForeignIndicator, "FOR" },
            { LineItemReferenceType.Usage, "USG" },
            { LineItemReferenceType.Material, "MAT" },
            { LineItemReferenceType.NoLicenseRequired, "NLR" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="LocationType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<LocationType, string> LocationTypeToStringMapper { get; } = new Dictionary<LocationType, string>()
        {
            { LocationType.ServicePoint, "servicepoint" },
            { LocationType.Locker, "locker" },
            { LocationType.PostOffice, "postoffice" },
            { LocationType.PostBank, "postbank" },
            { LocationType.POBox, "pobox" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MeasurmentUnit"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<MeasurmentUnit, string> MeasurmentUnitToStringMapper { get; } = new Dictionary<MeasurmentUnit, string>()
        {
            { MeasurmentUnit.Imperial, "imperial" },
            { MeasurmentUnit.Metric, "metric" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MonetaryAmountType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<MonetaryAmountType, string> MonetaryAmountTypeToStringMapper { get; } = new Dictionary<MonetaryAmountType, string>()
        {
            { MonetaryAmountType.DeclaredValue, "declaredValue" },
            { MonetaryAmountType.InsuredValue, "insuredValue" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="NetworkType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<NetworkType, string> NetworkTypeToStringMapper { get; } = new Dictionary<NetworkType, string>()
        {
            { NetworkType.DayDefinite, "DD" },
            { NetworkType.TimeDefinite, "TD" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PackagingType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<PackagingType, string> PackagingTypeToStringMapper { get; } = new Dictionary<PackagingType, string>()
        {
            { PackagingType.Code_3BX, "3BX" },
            { PackagingType.Code_2BC, "2BC" },
            { PackagingType.Code_2BP, "2BP" },
            { PackagingType.Code_CE1, "CE1" },
            { PackagingType.Code_7BX, "7BX" },
            { PackagingType.Code_6BX, "6BX" },
            { PackagingType.Code_4BX, "4BX" },
            { PackagingType.Code_2BX, "2BX" },
            { PackagingType.Code_1CE, "1CE" },
            { PackagingType.Code_WB1, "WB1" },
            { PackagingType.Code_WB3, "WB3" },
            { PackagingType.Code_XPD, "XPD" },
            { PackagingType.Code_8BX, "8BX" },
            { PackagingType.Code_5BX, "5BX" },
            { PackagingType.Code_WB6, "WB6" },
            { PackagingType.Code_TBL, "TBL" },
            { PackagingType.Code_TBS, "TBS" },
            { PackagingType.Code_WB2, "WB2" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PaymentMethod"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<PaymentMethod, string> PaymentMethodToStringMapper { get; } = new Dictionary<PaymentMethod, string>()
        {
            { PaymentMethod.Cash, "cash" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PickupLocation"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<PickupLocation, string> PickupLocationToStringMapper { get; } = new Dictionary<PickupLocation, string>()
        {
            { PickupLocation.Business, "business" },
            { PickupLocation.Residence, "residence" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ProductType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ProductType, string> ProductTypeToStringMapper { get; } = new Dictionary<ProductType, string>()
        {
            { ProductType.All, "all" },
            { ProductType.TimeDefinite, "timeDefinite" },
            { ProductType.DayDefinite, "dayDefinite" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ProviderType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ProviderType, string> ProviderTypeToStringMapper { get; } = new Dictionary<ProviderType, string>()
        {
            { ProviderType.Express, "express" },
            { ProviderType.Parcel, "parcel" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="QuantityType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<QuantityType, string> QuantityTypeToStringMapper { get; } = new Dictionary<QuantityType, string>()
        {
            { QuantityType.Part, "prt" },
            { QuantityType.Box, "box" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="QuantityUnitOfMeasurement"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<QuantityUnitOfMeasurement, string> QuantityUnitOfMeasurementToStringMapper { get; } = new Dictionary<QuantityUnitOfMeasurement, string>()
        {
            { QuantityUnitOfMeasurement.Milligrams, "3GM" },
            { QuantityUnitOfMeasurement.Centigrams, "2GM" },
            { QuantityUnitOfMeasurement.Grams, "GM" },
            { QuantityUnitOfMeasurement.Kilograms, "KG" },
            { QuantityUnitOfMeasurement.Centimeters, "CM" },
            { QuantityUnitOfMeasurement.Meters, "M" },
            { QuantityUnitOfMeasurement.SquareCentimeters, "CM2" },
            { QuantityUnitOfMeasurement.SquareMeters, "M2" },
            { QuantityUnitOfMeasurement.Milliliters, "3L" },
            { QuantityUnitOfMeasurement.Liters, "L" },
            { QuantityUnitOfMeasurement.Gallons, "2L" },
            { QuantityUnitOfMeasurement.Ounces, "2KG" },
            { QuantityUnitOfMeasurement.Pounds, "3KG" },
            { QuantityUnitOfMeasurement.Yards, "3M" },
            { QuantityUnitOfMeasurement.SquareFeet, "2M2" },
            { QuantityUnitOfMeasurement.SquareInches, "3M2" },
            { QuantityUnitOfMeasurement.SquareYards, "4M2" },
            { QuantityUnitOfMeasurement.CubicCentimeters, "2M3" },
            { QuantityUnitOfMeasurement.CubicMeters, "M3" },
            { QuantityUnitOfMeasurement.CubicFeet, "3M3" },
            { QuantityUnitOfMeasurement.Dozen, "DOZ" },
            { QuantityUnitOfMeasurement.DozenPairs, "DPR" },
            { QuantityUnitOfMeasurement.Pairs, "PRS" },
            { QuantityUnitOfMeasurement.Boxes, "BOX" },
            { QuantityUnitOfMeasurement.Pieces, "PCS" },
            { QuantityUnitOfMeasurement.Each, "2NO" },
            { QuantityUnitOfMeasurement.Gross, "GRS" },
            { QuantityUnitOfMeasurement.NoUnitRequired, "X" },
            { QuantityUnitOfMeasurement.Number, "NO" },
            { QuantityUnitOfMeasurement.Cone, "CONE" },
            { QuantityUnitOfMeasurement.Carat, "CT" },
            { QuantityUnitOfMeasurement.EA, "EA" },
            { QuantityUnitOfMeasurement.Rill, "RILL" },
            { QuantityUnitOfMeasurement.Roll, "ROLL" },
            { QuantityUnitOfMeasurement.Set, "SET" },
            { QuantityUnitOfMeasurement.TimeUnit, "TU" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ReferenceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ReferenceType, string> ReferenceTypeToStringMapper { get; } = new Dictionary<ReferenceType, string>()
        {
            { ReferenceType.CustomerReference, "customer-reference" },
            { ReferenceType.CustomerConfirmationNumber, "customer-confirmation-number" },
            { ReferenceType.LocalTrackingNumber, "local-tracking-number" },
            { ReferenceType.EcommerceNumber, "ecommerce-number" },
            { ReferenceType.Housebill, "housebill" },
            { ReferenceType.Masterbill, "masterbill" },
            { ReferenceType.ContainerNumber, "container-number" },
            { ReferenceType.ShipmentId, "shipment-id" },
            { ReferenceType.DomesticConsignmentId, "domestic-cosignment-id" },
            { ReferenceType.Reference, "reference" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ServicePoint"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ServicePoint, string> ServicePointToStringMapper { get; } = new Dictionary<ServicePoint, string>()
        {
            { ServicePoint. City, "CTY"},
            { ServicePoint. Station, "STN"},
            { ServicePoint. Partner, "PRT"},
            { ServicePoint. TwentyFourSeven, "247"},
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ServicePointStatus"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ServicePointStatus, string> ServicePointStatusToStringMapper { get; } = new Dictionary<ServicePointStatus, string>()
        {
            { ServicePointStatus.ServiceAvailable, "A" },
            { ServicePointStatus.ServiceSuspended, "S" },
            { ServicePointStatus.ServiceUnavailable, "U" },
            { ServicePointStatus.Closed, "X" },
            { ServicePointStatus.NotYetOpen, "Y" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ServiceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ServiceType, string> ServiceTypeToStringMapper { get; } = new Dictionary<ServiceType, string>()
        {
            { ServiceType.ParcelPickup, "parcel:pick-up" },
            { ServiceType.ParcelDropOff, "parcel:drop-off" },
            { ServiceType.ExpressPickup, "express:pick-up" },
            { ServiceType.ExpressDropOff, "express:drop-off" },
            { ServiceType.ExpressDropOffAccount, "express:drop-off-account" },
            { ServiceType.ExpressDropOffEasy, "express:drop-off-easy" },
            { ServiceType.ExpressDropOffPrelabeled, "express:drop-off-prelabeled" },
            { ServiceType.ParcelPickupRegistered, "parcel:pickup-registered" },
            { ServiceType.ParcelPickupUnregistered, "parcel:pickup-unregistered" },
            { ServiceType.ParcelDropOffUnregistered, "parcel:drop-off-unregistered" },
            { ServiceType.LetterService, "letter-service" },
            { ServiceType.Postbank, "postbank" },
            { ServiceType.CashOnDelivery, "cash-on-delivery" },
            { ServiceType.Franking, "franking" },
            { ServiceType.CashService, "cash-service" },
            { ServiceType.PackagingMaterial, "packaging-material" },
            { ServiceType.Postident, "postident" },
            { ServiceType.AgeVerification, "age-verification" },
            { ServiceType.HandicappedAccess, "handicapped-access" },
            { ServiceType.Parking, "parking" },
            { ServiceType.ParcelDropOffUnlabeled, "parcel:drop-off-unlabeled" },
            { ServiceType.ExpressDropOffUnlabeled, "express:drop-off-unlabeled" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ShipmentPurpose"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ShipmentPurpose, string> ShipmentPurposeToStringMapper { get; } = new Dictionary<ShipmentPurpose, string>()
        {
            { ShipmentPurpose.Personal, "personal" },
            { ShipmentPurpose.Commercial, "commercial" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ShipmentServiceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ShipmentServiceType, string> ShipmentServiceTypeToStringMapper { get; } = new Dictionary<ShipmentServiceType, string>()
        {
            { ShipmentServiceType.Freight, "freight" },
            { ShipmentServiceType.Express, "express" },
            { ShipmentServiceType.PostDE, "post-de" },
            { ShipmentServiceType.ParcelDE, "parcel-de" },
            { ShipmentServiceType.ParcelNL, "parcel-nl" },
            { ShipmentServiceType.ParcelPL, "parcel-pl" },
            { ShipmentServiceType.ParcelUK, "parcel-uk" },
            { ShipmentServiceType.DSC, "dsc" },
            { ShipmentServiceType.DGF, "dgf" },
            { ShipmentServiceType.Ecommerce, "ecommerce" },
            { ShipmentServiceType.EcommerceEurope, "ecommerce-europe" },
            { ShipmentServiceType.SVB, "svb" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ShipperReference"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ShipperReference, string> ShipperReferenceToStringMapper { get; } = new Dictionary<ShipperReference, string>()
        {
            { ShipperReference.ShipmentReferenceNumberOfReceiver, "AAO" },
            { ShipperReference.ReferenceNumberOfConsignor, "CU" },
            { ShipperReference.ReferenceNumberOfFreightForwarder, "FF" },
            { ShipperReference.FreightBillNumber, "FN" },
            { ShipperReference.InboundCenterReferenceNumber, "IBC" },
            { ShipperReference.LoadListReference, "LLR" },
            { ShipperReference.OutboundCenterReferenceNumber, "OBC" },
            { ShipperReference.PickupRequestNumber, "PRN" },
            { ShipperReference.LocalPayerAccountNumber, "ACP" },
            { ShipperReference.LocalShipperAccountNumber, "ACS" },
            { ShipperReference.LocalReceiverAccountNumber, "ACR" },
            { ShipperReference.CustomsDeclarationNumber, "CDN" },
            { ShipperReference.EurologShipmentId, "STD" },
            { ShipperReference.BuyersOrderNumber, "CO" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ShippingRole"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ShippingRole, string> ShippingRoleToStringMapper { get; } = new Dictionary<ShippingRole, string>()
        {
            { ShippingRole.Payer, "payer" },
            { ShippingRole.Shipper, "shipper" },
            { ShippingRole.DutiesTaxes, "duties-taxes" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="SpecialServiceChargeCode"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<SpecialServiceChargeCode, string> SpecialServiceChargeCodeToStringMapper { get; } = new Dictionary<SpecialServiceChargeCode, string>()
        {
            { SpecialServiceChargeCode.ExtraCharge, "XCH" },
            { SpecialServiceChargeCode.Fee, "FEE" },
            { SpecialServiceChargeCode.Surcharge, "SCH" },
            { SpecialServiceChargeCode.NonRevenueItem, "NRI" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="StatusCodeType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<StatusCodeType, string> StatusCodeTypeToStringMapper { get; } = new Dictionary<StatusCodeType, string>()
        {
            { StatusCodeType.PreTransit, "pre-transit" },
            { StatusCodeType.Transit, "transit" },
            { StatusCodeType.Delivered, "delivered" },
            { StatusCodeType.Failure, "failure" },
            { StatusCodeType.Unknown, "unknown" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TaxIdentifier"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<TaxIdentifier, string> TaxIdentiferToStringMapper { get; } = new Dictionary<TaxIdentifier, string>()
        {
            { TaxIdentifier.ValueAddedTax, "VAT" },
            { TaxIdentifier.EmployerIdentificationNumber, "EIN" },
            { TaxIdentifier.GoodsAndServiceTax, "GST" },
            { TaxIdentifier.SocialSecurityNumber, "SSN" },
            { TaxIdentifier.EuropeanUnionRegistrastionAndIdentification, "EOR" },
            { TaxIdentifier.DataUniversalNumberingSystem, "DUN" },
            { TaxIdentifier.FederalTaxId, "FED" },
            { TaxIdentifier.StateTaxId, "STA" },
            { TaxIdentifier.CNP, "CNP" },
            { TaxIdentifier.IE, "IE" },
            { TaxIdentifier.RussiaBankDetailsSection, "INN" },
            { TaxIdentifier.KPP, "KPP" },
            { TaxIdentifier.OGR, "OGR" },
            { TaxIdentifier.OKP, "OKP" },
            { TaxIdentifier.SDT, "SDT" },
            { TaxIdentifier.FreeTradeZone, "FTZ" },
            { TaxIdentifier.DefermentAccountDutiesOnly, "DAN" },
            { TaxIdentifier.DefermentAccountTaxOnly, "TAN" },
            { TaxIdentifier.DefermentAccountDutiesTaxesAndFeesOnly, "DTF" },
            { TaxIdentifier.RegisteredExportersRegistrationId, "RGP" },
            { TaxIdentifier.DriversLicense, "DLI" },
            { TaxIdentifier.NationalIdentityCard, "NID" },
            { TaxIdentifier.Passport, "PAS" },
            { TaxIdentifier.ManufacturersId, "MID" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TotalChargeType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<TotalChargeType, string> TotalChargeTypeToStringMapper { get; } = new Dictionary<TotalChargeType, string>()
        {
            { TotalChargeType.QuotedShipmentTotalDiscount, "STDIS" },
            { TotalChargeType.ShipmentCustomsValue, "SCUSV" },
            { TotalChargeType.ShipmentInsuredValue, "SINSV" },
            { TotalChargeType.ShipmentQuoteDiscount, "SPRQD" },
            { TotalChargeType.SPRQN, "SPRQN" },
            { TotalChargeType.STSCH, "STSCH" },
            { TotalChargeType.MACHG, "MACHG" },
            { TotalChargeType.MFCHG, "MFCHG" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TrackingView"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<TrackingView, string> TrackingViewToStringMapper { get; } = new Dictionary<TrackingView, string>()
        {
            { TrackingView.AllCheckpoints, "all-checkpoints" },
            { TrackingView.LastCheckpoint, "last-checkpoint" },
            { TrackingView.ShipmentDetailsOnly, "shipment-details-only" },
            { TrackingView.AdvanceShipment, "advance-shipment" },
            { TrackingView.BbxChildren, "bbx-children" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TransportationMode"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<TransportationMode, string> TransportationModeToStringMapper { get; } = new Dictionary<TransportationMode, string>()
        {
            { TransportationMode.Air, "air" },
            { TransportationMode.Ocean, "ocean" },
            { TransportationMode.Ground, "ground" }
        }.ToImmutableDictionary();

        public static IReadOnlyDictionary<TypeCode, string> TypeCodeToStringMapper { get; } = new Dictionary<TypeCode, string>()
        {
            { TypeCode.TotalTaxForTheShipment, "STTXA" },
            { TypeCode.TotalDiscountForTheShipment, "STDIS" },
            { TypeCode.NetShipmentWeightCharge, "SPQRT" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ValueAddedService"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ValueAddedService, string> ValueAddedServiceToStringMapper { get; } = new Dictionary<ValueAddedService, string>()
        {
            { ValueAddedService.AllValueAddedServices, "allValueAddedServices" },
            { ValueAddedService.AllValueAddedServicesAndRuleGroups, "allValueAddedServicesAndRuleGroups" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="WeightUnit"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<WeightUnit, string> WeightUnitToStringMapper { get; } = new Dictionary<WeightUnit, string>()
        {
            { WeightUnit.Kg, "kg" },
            { WeightUnit.Lb, "lb" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CountryCode"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CountryCode, string> CountryCodeToStringMapper { get; } = Enum.GetValues<CountryCode>().ToImmutableDictionary(x => x, x => x.ToString().ToLower());

        /// <summary>
        /// Maps the <see cref="LanguageCode"/> to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<LanguageCode, string> LanguageCodeToStringMapper { get; } = Enum.GetValues<LanguageCode>().ToImmutableDictionary(x => x, x => x.ToString().ToLower());

        public static IReadOnlyDictionary<ThreeLetterLanguageCode, string> ThreeLetterLanguageCodeToStringMapper { get; } = new Dictionary<ThreeLetterLanguageCode, string>()
        {
            { ThreeLetterLanguageCode.Afrikaans, "afr" },
            { ThreeLetterLanguageCode.Albanian, "alb" },
            { ThreeLetterLanguageCode.Amharic, "amh" },
            { ThreeLetterLanguageCode.Arabic, "ara" },
            { ThreeLetterLanguageCode.Armenian, "arm" },
            { ThreeLetterLanguageCode.Azerbaijani, "aze" },
            { ThreeLetterLanguageCode.Bengali, "ben" },
            { ThreeLetterLanguageCode.Bosnian, "bos" },
            { ThreeLetterLanguageCode.Bulgarian, "bul" },
            { ThreeLetterLanguageCode.Burmese, "bur" },
            { ThreeLetterLanguageCode.Catalan, "cat" },
            { ThreeLetterLanguageCode.Chinese, "chi" },
            { ThreeLetterLanguageCode.Croatian, "hrv" },
            { ThreeLetterLanguageCode.Czech, "ces" },
            { ThreeLetterLanguageCode.Danish, "dan" },
            { ThreeLetterLanguageCode.Dutch, "dut" },
            { ThreeLetterLanguageCode.English, "eng" },
            { ThreeLetterLanguageCode.Esperanto, "epo" },
            { ThreeLetterLanguageCode.Estonian, "est" },
            { ThreeLetterLanguageCode.Filipino, "fil" },
            { ThreeLetterLanguageCode.Finnish, "fin" },
            { ThreeLetterLanguageCode.French, "fre" },
            { ThreeLetterLanguageCode.Georgian, "geo" },
            { ThreeLetterLanguageCode.German, "ger" },
            { ThreeLetterLanguageCode.Greek, "gre" },
            { ThreeLetterLanguageCode.Gujarati, "guj" },
            { ThreeLetterLanguageCode.Hebrew, "heb" },
            { ThreeLetterLanguageCode.Hindi, "hin" },
            { ThreeLetterLanguageCode.Hungarian, "hun" },
            { ThreeLetterLanguageCode.Icelandic, "ice" },
            { ThreeLetterLanguageCode.Indonesian, "ind" },
            { ThreeLetterLanguageCode.Irish, "gle" },
            { ThreeLetterLanguageCode.Italian, "ita" },
            { ThreeLetterLanguageCode.Japanese, "jpn" },
            { ThreeLetterLanguageCode.Kannada, "kan" },
            { ThreeLetterLanguageCode.Korean, "kor" },
            { ThreeLetterLanguageCode.Latin, "lat" },
            { ThreeLetterLanguageCode.Latvian, "lav" },
            { ThreeLetterLanguageCode.Lithuanian, "lit" },
            { ThreeLetterLanguageCode.Macedonian, "mac" },
            { ThreeLetterLanguageCode.Malay, "may" },
            { ThreeLetterLanguageCode.Maltese, "mlt" },
            { ThreeLetterLanguageCode.Marathi, "mar" },
            { ThreeLetterLanguageCode.Nepali, "nep" },
            { ThreeLetterLanguageCode.Norwegian, "nor" },
            { ThreeLetterLanguageCode.Persian, "per" },
            { ThreeLetterLanguageCode.Polish, "pol" },
            { ThreeLetterLanguageCode.Portuguese, "por" },
            { ThreeLetterLanguageCode.Punjabi, "pan" },
            { ThreeLetterLanguageCode.Romanian, "rum" },
            { ThreeLetterLanguageCode.Russian, "rus" },
            { ThreeLetterLanguageCode.Serbian, "srp" },
            { ThreeLetterLanguageCode.Sinhalese, "sin" },
            { ThreeLetterLanguageCode.Slovak, "slk" },
            { ThreeLetterLanguageCode.Slovenian, "slv" },
            { ThreeLetterLanguageCode.Spanish, "spa" },
            { ThreeLetterLanguageCode.Swahili, "swa" },
            { ThreeLetterLanguageCode.Swedish, "swe" },
            { ThreeLetterLanguageCode.Tamil, "tam" },
            { ThreeLetterLanguageCode.Telugu, "tel" },
            { ThreeLetterLanguageCode.Thai, "tha" },
            { ThreeLetterLanguageCode.Turkish, "tur" },
            { ThreeLetterLanguageCode.Ukrainian, "ukr" },
            { ThreeLetterLanguageCode.Urdu, "urd" },
            { ThreeLetterLanguageCode.Vietnamese, "vie" },
            { ThreeLetterLanguageCode.Welsh, "wel" },
            { ThreeLetterLanguageCode.Xhosa, "xho" },
            { ThreeLetterLanguageCode.Yiddish, "yid" },
            { ThreeLetterLanguageCode.Zulu, "zul" }
    }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CountryCode"/> to their related country name <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CountryCode, string> CountryCodeToCountryNameMapper { get; } = new Dictionary<CountryCode, string>()
        {
            { CountryCode.AD, "Andorra" },
            { CountryCode.AE, "United Arab Emirates" },
            { CountryCode.AF, "Afghanistan" },
            { CountryCode.AG, "Antigua And Barbuda" },
            { CountryCode.AI, "Anguilla" },
            { CountryCode.AL, "Albania" },
            { CountryCode.AM, "Armenia" },
            { CountryCode.AN, "Netherlands Antilles" },
            { CountryCode.AO, "Angola" },
            { CountryCode.AQ, "Antarctica" },
            { CountryCode.AR, "Argentina" },
            { CountryCode.AS, "American Samoa" },
            { CountryCode.AT, "Austria" },
            { CountryCode.AU, "Australia" },
            { CountryCode.AW, "Aruba" },
            { CountryCode.AX, "Aland Islands" },
            { CountryCode.AZ, "Azerbaijan" },
            { CountryCode.BA, "Bosnia And Herzegovina" },
            { CountryCode.BB, "Barbados" },
            { CountryCode.BD, "Bangladesh" },
            { CountryCode.BE, "Belgium" },
            { CountryCode.BF, "Burkina Faso" },
            { CountryCode.BG, "Bulgaria" },
            { CountryCode.BH, "Bahrain" },
            { CountryCode.BI, "Burundi" },
            { CountryCode.BJ, "Benin" },
            { CountryCode.BL, "Saint Barthelemy" },
            { CountryCode.BM, "Bermuda" },
            { CountryCode.BN, "Brunei" },
            { CountryCode.BO, "Bolivia" },
            { CountryCode.BR, "Brazil" },
            { CountryCode.BS, "Bahamas" },
            { CountryCode.BT, "Bhutan" },
            { CountryCode.BV, "Bouvet Island" },
            { CountryCode.BW, "Botswana" },
            { CountryCode.BY, "Belarus" },
            { CountryCode.BZ, "Belize" },
            { CountryCode.CA, "Canada" },
            { CountryCode.CC, "Cocos Islands" },
            { CountryCode.CD, "Democratic Republicofthe Congo" },
            { CountryCode.CF, "Central African Republic" },
            { CountryCode.CG, "Republicofthe Congo" },
            { CountryCode.CH, "Switzerland" },
            { CountryCode.CI, "Ivory Coast" },
            { CountryCode.CK, "Cook Islands" },
            { CountryCode.CL, "Chile" },
            { CountryCode.CM, "Cameroon" },
            { CountryCode.CN, "China" },
            { CountryCode.CO, "Colombia" },
            { CountryCode.CR, "Costa Rica" },
            { CountryCode.CU, "Cuba" },
            { CountryCode.CV, "Cape Verde" },
            { CountryCode.CX, "Christmas Island" },
            { CountryCode.CY, "Cyprus" },
            { CountryCode.CZ, "Czech Republic" },
            { CountryCode.DE, "Germany" },
            { CountryCode.DJ, "Djibouti" },
            { CountryCode.DK, "Denmark" },
            { CountryCode.DM, "Dominica" },
            { CountryCode.DO, "Dominican Republic" },
            { CountryCode.DZ, "Algeria" },
            { CountryCode.EC, "Ecuador" },
            { CountryCode.EE, "Estonia" },
            { CountryCode.EG, "Egypt" },
            { CountryCode.EH, "Western Sahara" },
            { CountryCode.ER, "Eritrea" },
            { CountryCode.ES, "Spain" },
            { CountryCode.ET, "Ethiopia" },
            { CountryCode.FI, "Finland" },
            { CountryCode.FJ, "Fiji" },
            { CountryCode.FK, "Falkland Islands" },
            { CountryCode.FM, "Micronesia" },
            { CountryCode.FO, "Faroe Islands" },
            { CountryCode.FR, "France" },
            { CountryCode.GA, "Gabon" },
            { CountryCode.GB, "United Kingdom" },
            { CountryCode.GD, "Grenada" },
            { CountryCode.GE, "Georgia" },
            { CountryCode.GF, "French Guiana" },
            { CountryCode.GG, "Guernsey" },
            { CountryCode.GH, "Ghana" },
            { CountryCode.GI, "Gibraltar" },
            { CountryCode.GL, "Greenland" },
            { CountryCode.GM, "Gambia" },
            { CountryCode.GN, "Guinea" },
            { CountryCode.GP, "Guadeloupe" },
            { CountryCode.GQ, "Equatorial Guinea" },
            { CountryCode.GR, "Greece" },
            { CountryCode.GS, "South GeorgiaΑndthe South Sandwich Islands" },
            { CountryCode.GT, "Guatemala" },
            { CountryCode.GU, "Guam" },
            { CountryCode.GW, "Guinea Bissau" },
            { CountryCode.GY, "Guyana" },
            { CountryCode.HK, "Hong Kong" },
            { CountryCode.HM, "Heard IslandΑnd Mc Donald Islands" },
            { CountryCode.HN, "Honduras" },
            { CountryCode.HR, "Croatia" },
            { CountryCode.HT, "Haiti" },
            { CountryCode.HU, "Hungary" },
            { CountryCode.ID, "Indonesia" },
            { CountryCode.IE, "Ireland" },
            { CountryCode.IL, "Israel" },
            { CountryCode.IM, "Isleof Man" },
            { CountryCode.IN, "India" },
            { CountryCode.IO, "British Indian Ocean Territory" },
            { CountryCode.IQ, "Iraq" },
            { CountryCode.IR, "Iran" },
            { CountryCode.IS, "Iceland" },
            { CountryCode.IT, "Italy" },
            { CountryCode.JE, "Jersey" },
            { CountryCode.JM, "Jamaica" },
            { CountryCode.JO, "Jordan" },
            { CountryCode.JP, "Japan" },
            { CountryCode.KE, "Kenya" },
            { CountryCode.KG, "Kyrgyzstan" },
            { CountryCode.KH, "Cambodia" },
            { CountryCode.KI, "Kiribati" },
            { CountryCode.KM, "Comoros" },
            { CountryCode.KN, "Saint KittsΑnd Nevis" },
            { CountryCode.KP, "North Korea" },
            { CountryCode.KR, "South Korea" },
            { CountryCode.KW, "Kuwait" },
            { CountryCode.KY, "Cayman Islands" },
            { CountryCode.KZ, "Kazakhstan" },
            { CountryCode.LA, "Laos" },
            { CountryCode.LB, "Lebanon" },
            { CountryCode.LC, "Saint Lucia" },
            { CountryCode.LI, "Liechtenstein" },
            { CountryCode.LK, "Sri Lanka" },
            { CountryCode.LR, "Liberia" },
            { CountryCode.LS, "Lesotho" },
            { CountryCode.LT, "Lithuania" },
            { CountryCode.LU, "Luxembourg" },
            { CountryCode.LV, "Latvia" },
            { CountryCode.LY, "Libya" },
            { CountryCode.MA, "Morocco" },
            { CountryCode.MC, "Monaco" },
            { CountryCode.MD, "Moldova" },
            { CountryCode.ME, "Montenegro" },
            { CountryCode.MF, "Saint Martin" },
            { CountryCode.MG, "Madagascar" },
            { CountryCode.MH, "Marshall Islands" },
            { CountryCode.MK, "Macedonia" },
            { CountryCode.ML, "Mali" },
            { CountryCode.MM, "Myanmar" },
            { CountryCode.MN, "Mongolia" },
            { CountryCode.MO, "Macau" },
            { CountryCode.MP, "Northern Mariana Islands" },
            { CountryCode.MQ, "Martinique" },
            { CountryCode.MR, "Mauritania" },
            { CountryCode.MS, "Montserrat" },
            { CountryCode.MT, "Malta" },
            { CountryCode.MU, "Mauritius" },
            { CountryCode.MV, "Maldives" },
            { CountryCode.MW, "Malawi" },
            { CountryCode.MX, "Mexico" },
            { CountryCode.MY, "Malaysia" },
            { CountryCode.MZ, "Mozambique" },
            { CountryCode.NA, "Namibia" },
            { CountryCode.NC, "New Caledonia" },
            { CountryCode.NE, "Niger" },
            { CountryCode.NF, "Norfolk Island" },
            { CountryCode.NG, "Nigeria" },
            { CountryCode.NI, "Nicaragua" },
            { CountryCode.NL, "Netherlands" },
            { CountryCode.NO, "Norway" },
            { CountryCode.NP, "Nepal" },
            { CountryCode.NR, "Nauru" },
            { CountryCode.NU, "Niue" },
            { CountryCode.NZ, "New Zealand" },
            { CountryCode.OM, "Oman" },
            { CountryCode.PA, "Panama" },
            { CountryCode.PE, "Peru" },
            { CountryCode.PF, "French Polynesia" },
            { CountryCode.PG, "Papua New Guinea" },
            { CountryCode.PH, "Philippines" },
            { CountryCode.PK, "Pakistan" },
            { CountryCode.PL, "Poland" },
            { CountryCode.PM, "Saint Pierre And Miquelon" },
            { CountryCode.PN, "Pitcairn" },
            { CountryCode.PR, "Puerto Rico" },
            { CountryCode.PS, "Palestine" },
            { CountryCode.PT, "Portugal" },
            { CountryCode.PW, "Palau" },
            { CountryCode.PY, "Paraguay" },
            { CountryCode.QA, "Qatar" },
            { CountryCode.RE, "Reunion" },
            { CountryCode.RO, "Romania" },
            { CountryCode.RS, "Serbia" },
            { CountryCode.RU, "Russia" },
            { CountryCode.RW, "Rwanda" },
            { CountryCode.SA, "Saudi Arabia" },
            { CountryCode.SB, "Solomon Islands" },
            { CountryCode.SC, "Seychelles" },
            { CountryCode.SD, "Sudan" },
            { CountryCode.SE, "Sweden" },
            { CountryCode.SG, "Singapore" },
            { CountryCode.SH, "Saint Helena" },
            { CountryCode.SI, "Slovenia" },
            { CountryCode.SJ, "Svalbard And Jan Mayen" },
            { CountryCode.SK, "Slovakia" },
            { CountryCode.SL, "Sierra Leone" },
            { CountryCode.SM, "San Marino" },
            { CountryCode.SN, "Senegal" },
            { CountryCode.SO, "Somalia" },
            { CountryCode.SR, "Suriname" },
            { CountryCode.ST, "Sao Tome And Principe" },
            { CountryCode.SV, "El Salvador" },
            { CountryCode.SY, "Syria" },
            { CountryCode.SZ, "Swaziland" },
            { CountryCode.TC, "Turks And Caicos Islands" },
            { CountryCode.TD, "Chad" },
            { CountryCode.TF, "French Southern Territories" },
            { CountryCode.TG, "Togo" },
            { CountryCode.TH, "Thailand" },
            { CountryCode.TJ, "Tajikistan" },
            { CountryCode.TK, "Tokelau" },
            { CountryCode.TL, "East Timor" },
            { CountryCode.TM, "Turkmenistan" },
            { CountryCode.TN, "Tunisia" },
            { CountryCode.TO, "Tonga" },
            { CountryCode.TR, "Turkey" },
            { CountryCode.TT, "Trinidad And Tobago" },
            { CountryCode.TV, "Tuvalu" },
            { CountryCode.TW, "Taiwan" },
            { CountryCode.TZ, "Tanzania" },
            { CountryCode.UA, "Ukraine" },
            { CountryCode.UG, "Uganda" },
            { CountryCode.UM, "United States Minor Outlying Islands" },
            { CountryCode.US, "United States" },
            { CountryCode.UY, "Uruguay" },
            { CountryCode.UZ, "Uzbekistan" },
            { CountryCode.VA, "Vatican" },
            { CountryCode.VC, "Saint Vincent Andthe Grenadines" },
            { CountryCode.VE, "Venezuela" },
            { CountryCode.VG, "British Virgin Islands" },
            { CountryCode.VI, "U S Virgin Islands" },
            { CountryCode.VN, "Vietnam" },
            { CountryCode.VU, "Vanuatu" },
            { CountryCode.WF, "WallisΑnd Futuna" },
            { CountryCode.WS, "Samoa" },
            { CountryCode.YE, "Yemen" },
            { CountryCode.YT, "Mayotte" },
            { CountryCode.ZA, "South Africa" },
            { CountryCode.ZM, "Zambia" },
            { CountryCode.ZW, "Zimbabwe" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Returns the localized representation of the specified <paramref name="value"/>
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns></returns>
        public static string ToLocalizedString(this CountryCode value) => CountryCodeToCountryNameMapper[value];
    }
}