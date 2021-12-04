using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.Models
{
    public class Product : BaseEntity
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public Brand Brand { get; set; }

        [Required]
        public ProductType Type { get; set; }

        [Required]
        public ICollection<HairType> HairTypes { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Volume { get; set; }
    }
}
