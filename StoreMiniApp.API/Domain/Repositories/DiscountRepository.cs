using StoreMiniApp.API.Domain.Data;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Interfaces;

namespace StoreMiniApp.API.Domain.Repositories
{
    public class DiscountRepository : GenericRepository<Discounts>, IDiscountRepository
    {
        public DiscountRepository(StoreMiniAppDbContext context) : base(context) { }
    }
}
