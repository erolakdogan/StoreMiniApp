﻿using StoreMiniApp.API.Domain.Data;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Interfaces;

namespace StoreMiniApp.API.Domain.Repositories
{
    public class InvoiceDetailRepository : GenericRepository<InvoiceDetails>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(StoreMiniAppDbContext context) : base(context) { }

    }
}
