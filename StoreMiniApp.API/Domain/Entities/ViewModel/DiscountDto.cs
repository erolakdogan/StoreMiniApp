namespace StoreMiniApp.API.Domain.Entities.ViewModel
{
    public class DiscountDto
    {
        public int DiscountId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Rate { get; set; }
        public bool IsRatePercentage { get; set; }
        public string CreatedDate { get; set; }
    }
}
