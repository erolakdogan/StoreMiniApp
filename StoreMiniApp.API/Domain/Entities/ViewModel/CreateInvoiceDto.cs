using StoreMiniApp.API.Domain.Entities.Model;

namespace StoreMiniApp.API.Domain.Entities.ViewModel
{
    public class CreateInvoiceDto
    {
        public string InvoiceNumber { get; set; }

        public int OrderId { get; set; }

        public decimal OrderTotal { get; set; }

        public List<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
