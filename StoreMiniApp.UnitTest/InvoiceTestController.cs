using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using StoreMiniApp.API.Controllers;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Entities.Model.Enum;
using StoreMiniApp.API.Domain.Entities.ViewModel;
using StoreMiniApp.API.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StoreMiniApp.UnitTest
{
    public class InvoiceTestController
    {
        private readonly Mock<IUnitOfWork> _mock;
        private readonly Mock<IMapper> _mapper;
        private readonly InvoiceController _invoiceController;
        private List<Invoice> _invoice;
       

        public InvoiceTestController()
        {
            _mock = new Mock<IUnitOfWork>();
            _invoiceController = new InvoiceController(_mock.Object, _mapper.Object);
        }

        [Theory]
        [InlineData(4)]
        public async void CreateInvoiceForEmployee_ThenOk_Test(int userId)
        {
            var randomNumber = new Random().Next(0, 10000).ToString();
            var invoiceNumber = $"BJK{randomNumber}";

            var invoice = new CreateInvoiceDto();
            invoice.InvoiceNumber = invoiceNumber;
            invoice.OrderTotal = 38;
            invoice.InvoiceDetails = new List<InvoiceDetails>();
            invoice.InvoiceDetails.Add(new InvoiceDetails()
            {
                ProductId = 1,
                ProductName = "Invoice Item Test",
                ProductPrice = 20,
                ProductQuantity = 2,
                DerivedProductCost = 40,
                DiscountPrice = 2,
                TotalDerivedCost = 38,
                CreatedDate = DateTime.Now
            });
            
            var result = await _invoiceController.GenerateInvoice(userId,invoice);

            Assert.IsType<OkObjectResult>(result);
        }

        [Theory]
        [InlineData("BJK010")]
        public async void GetInvoiceByBillNumber__ThenOk_Test(string BillNumber)
        {
            var result = await _invoiceController.GetInvoice(BillNumber);
            Assert.IsType<OkObjectResult>(result);
        }

    }

}