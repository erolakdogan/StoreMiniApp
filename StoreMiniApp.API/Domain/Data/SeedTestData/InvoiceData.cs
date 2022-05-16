using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMiniApp.API.Domain.Entities.Model;

namespace StoreMiniApp.API.Domain.Data.SeedTestData
{
    public class InvoiceData : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasData
            (
                new Invoice { Id = 1, OrderId = 1, InvoiceNumber = "BJK010", UserId = 1, Total = 500 },
                new Invoice { Id = 2, OrderId = 2, InvoiceNumber = "BJK011", UserId = 2, Total = 1500 },
                new Invoice { Id = 3, OrderId = 3, InvoiceNumber = "BJK012", UserId = 3, Total = 990 },
                new Invoice { Id = 4, OrderId = 4, InvoiceNumber = "BJK013", UserId = 4, Total = 920 }
            );
        }
    }
}
