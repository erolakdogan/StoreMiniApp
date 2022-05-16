using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using StoreMiniApp.API.Controllers;
using StoreMiniApp.API.Domain.Entities.Model.Enum;
using StoreMiniApp.API.Domain.Entities.ViewModel;
using StoreMiniApp.API.Domain.Interfaces;
using Xunit;

namespace StoreMiniApp.UnitTest
{
    public class DiscountsTestController 
    {
        //private readonly IMapper _mapper;
        //private readonly Mock<IUnitOfWork> _repo;
        //private readonly DiscountsController _controller;

        //public DiscountsTestController()
        //{
        //    _repo  = new Mock<IUnitOfWork>();
        //    _controller = new DiscountsController(_repo.Object, _mapper);
        //}
        
        //[Fact]
        //public async void GetAllDiscounts_ThenOk_Test()
        //{
        //    var result = await _controller.GetAllDiscounts();
        //    Assert.IsType<OkObjectResult>(result);
        //}

        //[Theory]
        //[InlineData(DiscountType.Employee)]
        //public async void GetUserByID__ThenOk_Test(DiscountType type)
        //{
        //    var result = await _controller.GetDiscount(type);
        //    Assert.IsType<OkObjectResult>(result);
        //}

        //[Fact]
        //public async void AddUser_WithNullData_ThenNotFound()
        //{
        //    CreateDiscountDto model = null;
        //    var result = await _controller.CreateDiscount(model);
        //    Assert.IsNotType<NotFoundObjectResult>(result);
        //}

        //[Fact]
        //public async void AddUser_WithTestData_ThenOk()
        //{
        //    CreateDiscountDto model = new CreateDiscountDto
        //    {
        //        Name = "New Customer 2022",
        //        Type = DiscountType.Customer.ToString(),
        //        Rate = 20,
        //        IsRatePercentage = true
        //    };
        //    var result = await _controller.CreateDiscount(model);
        //    Assert.IsType<OkObjectResult>(result);
        //}

    }

}