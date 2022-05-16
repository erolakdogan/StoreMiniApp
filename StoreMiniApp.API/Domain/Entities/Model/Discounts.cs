using StoreMiniApp.API.Domain.Entities.Model.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMiniApp.API.Domain.Entities.Model
{
    [Table("Discounts")]
    public partial class Discounts : BaseModel
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        public DiscountType Type { get; set; }

        [Required]
        public decimal Rate { get; set; }

        public bool IsRatePercentage { get; set; }
    }
}
