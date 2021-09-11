using System;

namespace RealEstateManagement.Entities
{
    public class Transaction
    {
        //BuyerInfo
        public string BuyerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IDType { get; set; }
        public string IDNo { get; set; }
        public bool BuyerInfoReceived {get;set;}

        //Offer
        public Guid OfferId { get; set; }
        public string UnitId { get; set; }
        public decimal OfferPrice { get; set; }
        public string OfferStatus { get; set; }
        public DateTime OfferInitiatedDate { get; set; }
        public DateTime OfferAcceptedDate { get; set; }
        public DateTime OfferCanceledDate { get; set; }
        public bool OfferReceived { get; set; }

        //UnitPlan
        public int Area { get; set; }
        public int UnitNo { get; set; }
        public string ProjectName { get; set; }
        public string Developer { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string UnitStatus { get; set; }
        public bool UnitPlanReceived { get; set; }
    }
}
