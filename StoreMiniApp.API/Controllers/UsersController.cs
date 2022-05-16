using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Entities.ViewModel;
using StoreMiniApp.API.Domain.Interfaces;

namespace StoreMiniApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UsersController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var users = await _unitOfWork.Users.GetAllAsync();
            var usersDto = _mapper.Map<IEnumerable<CustomerUsersDto>>(users);
            return Ok(usersDto);
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<ActionResult> GetUserById(int id)
        {
            var user =  await _unitOfWork.Users.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound("User Not Found");
            }

            var usersDto = _mapper.Map<CustomerUsersDto>(user);
            return Ok(usersDto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(CreateCustomerUserDto userDto)
        {
            var userEntity = _mapper.Map<Users>(userDto);
            await _unitOfWork.Users.AddAsync(userEntity);
            _unitOfWork.Save();
            var userToReturn = _mapper.Map<CustomerUsersDto>(userEntity);

            return CreatedAtRoute("GetUser", new { Id = userToReturn.UserId }, userToReturn);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            _unitOfWork.Users.Remove(user);
            _unitOfWork.Save();

            return Ok();
        }
    }
}
