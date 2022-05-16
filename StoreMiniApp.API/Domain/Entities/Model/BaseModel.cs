using System.ComponentModel.DataAnnotations;

namespace StoreMiniApp.API.Domain.Entities.Model
{
    public class BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
