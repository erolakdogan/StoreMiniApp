namespace StoreMiniApp.API.Domain.Entities.ViewModel
{
    public class CreateDiscountDto
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Rate { get; set; }

        public bool IsRatePercentage { get; set; }
    }
}
