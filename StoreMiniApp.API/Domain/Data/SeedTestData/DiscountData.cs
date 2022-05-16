using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Entities.Model.Enum;

namespace StoreMiniApp.API.Domain.Data.SeedTestData
{
    public class DiscountData : IEntityTypeConfiguration<Discounts>
    {
        public void Configure(EntityTypeBuilder<Discounts> builder)
        {
            builder.HasData
            (
                new Discounts { Id = 1, Name = "Affiliate Discount", Type = DiscountType.Affiliate, Rate = 10, IsRatePercentage = true },
                new Discounts { Id = 2, Name = "Employee Discount", Type = DiscountType.Employee, Rate = 30, IsRatePercentage = true },
                new Discounts { Id = 3, Name = "Loyal Customer Discount", Type = DiscountType.Customer, Rate = 5, IsRatePercentage = true },
                new Discounts { Id = 4, Name = "Price Discount", Type = DiscountType.Price, Rate = 5, IsRatePercentage = false }
            );
        }
    }
}
