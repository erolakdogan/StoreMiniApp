using StoreMiniApp.API.Domain.Data;
using StoreMiniApp.API.Domain.Interfaces;
using StoreMiniApp.API.Domain.Repositories;

namespace StoreMiniApp.API.Domain.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private StoreMiniAppDbContext _context;
        public UnitOfWork(StoreMiniAppDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Invoices = new InvoiceRepository(_context);
            Discounts = new DiscountRepository(_context);
            InvoiceDetails = new InvoiceDetailRepository(_context);
        }

        public IUserRepository Users { get; private set; }

        public IInvoiceRepository Invoices { get; private set; }

        public IDiscountRepository Discounts { get; private set; }

        public IInvoiceDetailRepository InvoiceDetails { get; private set; }
        public void Dispose()
        {
            _context.Dispose();
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
