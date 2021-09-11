
namespace AzureFunctionDemo.DTOs
{
    public class UnitPlan : IEntity
    {
        public string UnitId { get; set; }
        public int Area { get; set; }
        public int UnitNo { get; set; }
        public string ProjectName { get; set; }
        public string Developer { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string UnitStatus { get; set; }

    }
}
