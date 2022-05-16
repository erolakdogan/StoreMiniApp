using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMiniApp.API.Domain.Entities.Model;

namespace StoreMiniApp.API.Domain.Data.SeedTestData
{
    public class InvoiceDetailsData : IEntityTypeConfiguration<InvoiceDetails>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetails> builder)
        {
            builder.HasData
            (
                //Customer
                new InvoiceDetails { Id = 1, InvoiceId = 1, ProductId = 2, ProductName = "Item 2", ProductPrice = 20, ProductQuantity = 2, DerivedProductCost = 40, DiscountPrice = 2, TotalDerivedCost = 38 },
                new InvoiceDetails { Id = 2, InvoiceId = 1, ProductId = 4, ProductName = "Item 4", ProductPrice = 482, ProductQuantity = 1, DerivedProductCost = 482, DiscountPrice = 20, TotalDerivedCost = 462 },
                new InvoiceDetails { Id = 3, InvoiceId = 2, ProductId = 40, ProductName = "Item 40", ProductPrice = 50, ProductQuantity = 5, DerivedProductCost = 250, DiscountPrice = 0, TotalDerivedCost = 250 },
                // Affiliate
                new InvoiceDetails { Id = 4, InvoiceId = 4, ProductId = 3, ProductName = "Item 3", ProductPrice = 50, ProductQuantity = 5, DerivedProductCost = 250, DiscountPrice = 25, TotalDerivedCost = 225 },
                new InvoiceDetails { Id = 5, InvoiceId = 3, ProductId = 5, ProductName = "Item 5", ProductPrice = 400, ProductQuantity = 1, DerivedProductCost = 400, DiscountPrice = 20, TotalDerivedCost = 380 },
                new InvoiceDetails { Id = 6, InvoiceId = 3, ProductId = 15, ProductName = "Item 15", ProductPrice = 77, ProductQuantity = 5, DerivedProductCost = 385, DiscountPrice = 0, TotalDerivedCost = 385 },
                // Employee
                new InvoiceDetails { Id = 7, InvoiceId = 4, ProductId = 105, ProductName = "Item 105", ProductPrice = 200, ProductQuantity = 5, DerivedProductCost = 1000, DiscountPrice = 80, TotalDerivedCost = 920 }
            );
        }
    }
}
