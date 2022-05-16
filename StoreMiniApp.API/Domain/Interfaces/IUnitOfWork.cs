namespace StoreMiniApp.API.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository Users
        {
            get;
        }
        IInvoiceRepository Invoices
        {
            get;
        }
        IInvoiceDetailRepository InvoiceDetails
        {
            get; 
        }
        IDiscountRepository Discounts
        {
            get; 
        }
        int Save();
    }
}
