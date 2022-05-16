using StoreMiniApp.API.Domain.Data;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Interfaces;

namespace StoreMiniApp.API.Domain.Repositories
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(StoreMiniAppDbContext context) : base(context) { }
    }
}
