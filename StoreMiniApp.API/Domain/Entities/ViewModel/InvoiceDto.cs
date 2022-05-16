using StoreMiniApp.API.Domain.Entities.Model;

namespace StoreMiniApp.API.Domain.Entities.ViewModel
{
    public class InvoiceDto
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public int OrderId { get; set; }
        public string CreatedDate { get; set; }
        public decimal Total { get; set; }
    }
}
