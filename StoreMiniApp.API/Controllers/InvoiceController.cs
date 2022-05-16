using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Entities.ViewModel;
using StoreMiniApp.API.Domain.Interfaces;

namespace StoreMiniApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InvoiceController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #region Fatura Getir
        /// <summary>
        /// Fatura Numarası ile fatura getirme.
        /// </summary>
        /// <remarks>FaturaGetir</remarks>
        /// <response code="200">İlgili fatura kaydı bulundu.</response>
        [HttpGet("{billNumber}")]
        public async Task<IActionResult> GetInvoice(string billNumber)
        {
            if (billNumber == null) return BadRequest();
            var invoice = await _unitOfWork.Invoices.FindAsync(x => x.InvoiceNumber == billNumber);
            if (invoice == null) return NotFound();
            var invoiceDto = _mapper.Map<InvoiceDto>(invoice);
            return Ok(invoiceDto.Total);
        }
        #endregion

        #region Fatura Oluştur
        /// <summary>
        /// Yeni bir fatura oluştur.
        /// </summary>
        /// <remarks>FaturaOluştur</remarks>
        /// <response code="200">Yeni fatura kaydı oluşturuldu.</response>
        [HttpPost]
        public async Task<IActionResult> GenerateInvoice (int userId, [FromBody] CreateInvoiceDto invoiceDto)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(userId);
            if (user == null) return NotFound();

            decimal invoiceSubtotal = 0;
            invoiceSubtotal = await ApplyDiscount(invoiceDto, invoiceSubtotal, user);

            var invoiceEntity = _mapper.Map<Invoice>(invoiceDto);
            invoiceEntity.Total = invoiceSubtotal;
            invoiceEntity.UserId = userId;
            invoiceEntity.CreatedDate = DateTime.Now;

            await _unitOfWork.Invoices.AddAsync(invoiceEntity);

            var invoiceDetails = _mapper.Map<InvoiceDetails>(invoiceDto.InvoiceDetails);
            await _unitOfWork.InvoiceDetails.AddAsync(invoiceDetails);
            _unitOfWork.Save();

            return Ok();
        }
        #endregion

        #region İndirim Uygulama.
        private async Task<decimal> ApplyDiscount(CreateInvoiceDto invoiceDto, decimal invoiceSubtotal, Users user)
        {
            var discounts = await _unitOfWork.Discounts.GetAllAsync();
            foreach (var discount in discounts)
            {
                if (discount.Equals(user.UserType) && discount.IsRatePercentage)
                {
                    var discountValue = invoiceDto.OrderTotal * (discount.Rate / 100);
                    invoiceSubtotal = invoiceDto.OrderTotal - discountValue;
                }

                foreach (var detail in invoiceDto.InvoiceDetails)
                {
                    if (detail.DerivedProductCost >= 100 && !discount.IsRatePercentage)
                    {
                        invoiceSubtotal -= discount.Rate;
                    }
                }
            }

            return invoiceSubtotal;
        }
        #endregion

    }
}
