namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the service type
    /// </summary>
    public enum ServiceType
    {
        /// <summary>
        /// Parcel pickup -> Consumers can pick up DHL parcel shipments. This applies to last mile.
        /// </summary>
        ParcelPickup = 0,

        /// <summary>
        /// Parcel drop off -> Consumers can drop off DHL Parcel shipments. This applies to first mile.
        /// </summary>
        ParcelDropOff = 1,

        /// <summary>
        /// Express pickup -> Consumers can pick up DHL Express shipments. This applies to last mile.
        /// </summary>
        ExpressPickup = 2,

        /// <summary>
        /// Express drop off -> Consumers can drop off DHL Express shipments. This applies to first mile.
        /// </summary>
        ExpressDropOff = 3,

        /// <summary>
        /// Express drop off account
        /// </summary>
        ExpressDropOffAccount = 4,

        /// <summary>
        /// Express drop off easy
        /// </summary>
        ExpressDropOffEasy = 5,

        /// <summary>
        /// Express drop off prelabeled
        /// </summary>
        ExpressDropOffPrelabeled = 6,

        /// <summary>
        /// Parcel pickup registered -> Automated locker station for DHL Parcel pick-up for pre-registered consumers
        /// </summary>
        ParcelPickupRegistered = 7,

        /// <summary>
        /// Parcel pickup unregistered -> Automated locker station for DHL Parcel pick-up for unregistered consumers
        /// </summary>
        ParcelPickupUnregistered = 8,

        /// <summary>
        /// Parcel drop off unregistered -> Automated locker station for DHL Parcel drop-off for unregistered consumers
        /// </summary>
        ParcelDropOffUnregistered = 9,

        /// <summary>
        /// Latter service
        /// </summary>
        LetterService = 10,

        /// <summary>
        /// Post bank
        /// </summary>
        Postbank = 11,

        /// <summary>
        /// Cash on delivery -> Offering of "cash on delivery". A shipment is only handed over to the recipient against payment.
        /// </summary>
        CashOnDelivery = 12,

        /// <summary>
        /// Franking -> Offering of labels for franking. This does not include the product "Mobile Paketmarke".
        /// </summary>
        Franking = 13,

        /// <summary>
        /// Cash service -> Cash service is offered via cash or card payment service. In Germany Giro, Maestro, Postcard and cash payment is supported.
        /// </summary>
        CashService = 14,

        /// <summary>
        /// Packaging material -> Offering for packing material such as packages for parcels, envelopes for letters, paper, pencils, pens.
        /// </summary>
        PackagingMaterial = 15,

        /// <summary>
        /// Postident -> Postident is a service to reliably verify the identity of a consumer. This service is commonly used for online bank account identity verification.
        /// </summary>
        Postident = 16,

        /// <summary>
        /// Age verification -> Reliable verification of the customers age. This service is commonly used to verify that the consumer has reached a specific age for an online offering
        /// </summary>
        AgeVerification = 17,

        /// <summary>
        /// Handicapped access -> Disabled fair access.
        /// </summary>
        HandicappedAccess = 18,

        /// <summary>
        /// Parking -> Parking area close by
        /// </summary>
        Parking = 19,

        /// <summary>
        /// Parcel drop off unlabeled -> Location that offers unlabeled drop-off for DHL Parcel shipments.
        /// </summary>
        ParcelDropOffUnlabeled = 20,

        /// <summary>
        /// Express drop off unlabeled -> Location that offers unlabeled drop-off for DHL Express shipments. This service is also known as label-free, label-less or QR code drop-off.
        /// </summary>
        ExpressDropOffUnlabeled = 21
    }
}
