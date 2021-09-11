using System;

namespace AzureFunctionDemo.DTOs
{
    public class BuyerInfo : IEntity
    {
        public string BuyerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IDType { get; set; }
        public string IDNo { get; set; }
    }
}
