using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMiniApp.API.Domain.Entities.Model;
using StoreMiniApp.API.Domain.Entities.Model.Enum;

namespace StoreMiniApp.API.Domain.Data.SeedTestData
{
    public class UserData : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData
            (
                new Users { Id = 1, FirstName = "Sergen ", LastName = "Yalçın", Address = "İstanbul", Email = "sergen@email.com", PhoneNumber = "123456789", UserType = UserType.Affiliate, CreatedDate = DateTime.Now.AddYears(-1) },
                new Users { Id = 2, FirstName = "İlhan ", LastName = "Mansız", Address = "Samsun", Email = "ilhan@email.com", PhoneNumber = "505542210", UserType = UserType.Affiliate, CreatedDate = DateTime.Now.AddYears(-2) },
                new Users { Id = 3, FirstName = "Metin ", LastName = "Tekin", Address = "Ankara", Email = "metin@email.com", PhoneNumber = "504425102", UserType = UserType.Employee, CreatedDate = DateTime.Now.AddYears(-3) },
                new Users { Id = 4, FirstName = "Ali ", LastName = "Gültekin", Address = "İstanbul", Email = "ali@email.com", PhoneNumber = "5057581801", UserType = UserType.Customer, CreatedDate = DateTime.Now.AddMonths(-3) },
                new Users { Id = 5, FirstName = "Feyyaz ", LastName = "Uçar", Address = "İstanbul", Email = "feyyaz@email.com", PhoneNumber = "5064581806", UserType = UserType.Employee, CreatedDate = DateTime.Now.AddYears(-3) }
            );
        }
    }
}
