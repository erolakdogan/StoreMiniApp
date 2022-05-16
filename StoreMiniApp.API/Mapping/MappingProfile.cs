using AutoMapper;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Entities.ViewModel;

namespace StoreMiniApp.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Users Mapp
            CreateMap<Users, CustomerUsersDto>()
                .ForMember(x => x.UserId, x => x.MapFrom(c => c.Id))
                .ForMember(x => x.CreatedDate, x => x.MapFrom(c => c.CreatedDate.Date.ToString("yyyy-MM-dd")));
            CreateMap<CreateCustomerUserDto, Users>();

            //Invoices Mapp
            CreateMap<Invoice, InvoiceDto>()
               .ForMember(x => x.InvoiceId, x => x.MapFrom(c => c.Id))
               .ForMember(x => x.CreatedDate, x => x.MapFrom(c => c.CreatedDate.Date.ToString("yyyy-MM-dd")));
            CreateMap<CreateInvoiceDto, Invoice>()
                .ForMember(x => x.Id, x => x.Ignore())
                .ForMember(x => x.CreatedDate, x => x.Ignore());
            
            //Discounts Mapp
            CreateMap<Discounts, DiscountDto>()
              .ForMember(x => x.DiscountId, x => x.MapFrom(c => c.Id))
              .ForMember(x => x.CreatedDate, x => x.MapFrom(c => c.CreatedDate.Date.ToString("yyyy-MM-dd")));

            CreateMap<CreateDiscountDto, Discounts>();

        }
    }
}
