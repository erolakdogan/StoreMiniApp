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
    public class UserTestController
    {
        private readonly Mock<IUnitOfWork> _mock;
        private readonly Mock<IMapper> _mapper;
        private readonly UsersController _usersController;
        private List<Users> _users;

        public UserTestController()
        {
            _mock = new Mock<IUnitOfWork>();
            _usersController = new UsersController(_mock.Object, _mapper.Object);

            #region testdata
            _users = new List<Users>
            {
                new Users { Id = 7, FirstName = "Sergen ", LastName = "Yalçýn", Address = "Ýstanbul", Email = "sergen@email.com", PhoneNumber = "123456789", UserType = UserType.Affiliate, CreatedDate = DateTime.Now.AddYears(-1) },
                new Users { Id = 8, FirstName = "Ýlhan ", LastName = "Mansýz", Address = "Samsun", Email = "ilhan@email.com", PhoneNumber = "505542210", UserType = UserType.Affiliate, CreatedDate = DateTime.Now.AddYears(-2) },
                new Users { Id = 9, FirstName = "Metin ", LastName = "Tekin", Address = "Ankara", Email = "metin@email.com", PhoneNumber = "504425102", UserType = UserType.Employee, CreatedDate = DateTime.Now.AddYears(-3) },
                new Users { Id = 10, FirstName = "Ali ", LastName = "Gültekin", Address = "Ýstanbul", Email = "ali@email.com", PhoneNumber = "5057581801", UserType = UserType.Customer, CreatedDate = DateTime.Now.AddMonths(-3) },
                new Users { Id = 11, FirstName = "Feyyaz ", LastName = "Uçar", Address = "Ýstanbul", Email = "feyyaz@email.com", PhoneNumber = "5064581806", UserType = UserType.Employee, CreatedDate = DateTime.Now.AddYears(-3) }

            };
            #endregion

        }

        [Fact]
        public async void GetAllUsers_ThenOk_Test()
        {
            var result = await _usersController.GetUsers();

            Assert.IsType<OkObjectResult>(result);
        }

        [Theory]
        [InlineData(1)]
        public async void GetUserByID__ThenOk_Test(int id)
        {
            var result = await _usersController.GetUserById(id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void AddUser_WithNullData_ThenNotFound()
        {
            CreateCustomerUserDto model = null;
            var result = await _usersController.CreateUser(model);
            Assert.IsNotType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async void AddUser_WithTestData_ThenOk()
        {
            CreateCustomerUserDto model  = new CreateCustomerUserDto
            {
                FirstName = "Ali",
                LastName = "Mehmet",
                Address = "aNKARA",
                Email = "test@mail.com",
                PhoneNumber = "5050555551"
            };
            var result = await _usersController.CreateUser(model);
            Assert.IsType<OkObjectResult>(result);
        }

    }

}