using System.ComponentModel.DataAnnotations;

namespace StoreMiniApp.API.Domain.Entities.ViewModel
{
    public class CreateCustomerUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [MaxLength(13)]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
