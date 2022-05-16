using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Entities.Model.Enum;
using StoreMiniApp.API.Domain.Entities.ViewModel;
using StoreMiniApp.API.Domain.Interfaces;

namespace StoreMiniApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DiscountsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllDiscounts()
        {
            var discounts = await _unitOfWork.Discounts.GetAllAsync();
            var discountsDto = _mapper.Map<IEnumerable<DiscountDto>>(discounts);
            return Ok(discountsDto);
        }

        [HttpGet("{type}")]
        public async Task<ActionResult<DiscountDto>> GetDiscount(DiscountType type)
        {
            var discount = await _unitOfWork.Discounts.FindByAsync(t => t.Type == type);
            if (discount == null)
            {
                return NotFound("Discount Not Found");
            }
            var discountDto = _mapper.Map<DiscountDto>(discount);
            if (discountDto.IsRatePercentage) return Ok($"%{discountDto.Rate}");

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateDiscount([FromBody] CreateDiscountDto discountDto)
        {
            var discountEntity = _mapper.Map<Discounts>(discountDto);

            await _unitOfWork.Discounts.AddAsync(discountEntity);
             _unitOfWork.Save();
            
            return Ok();
         }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var discounts = await _unitOfWork.Discounts.GetByIdAsync(id);
            if (discounts == null)
            {
                return NotFound();
            }
            _unitOfWork.Discounts.Remove(discounts);
            _unitOfWork.Save();

            return Ok();
        }
    }
}