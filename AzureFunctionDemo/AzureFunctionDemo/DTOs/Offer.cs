using System;

namespace AzureFunctionDemo.DTOs
{
    public class Offer : IEntity
    {
        public Guid OfferId { get; set; }
        public string UnitId { get; set; }
        public string BuyerId { get; set; }
        public decimal OfferPrice { get; set; }
        public string OfferStatus { get; set; }
        public DateTime OfferInitiatedDate { get; set; }
        public DateTime OfferAcceptedDate { get; set; }
        public DateTime OfferCanceledDate { get; set; }
    }
}
