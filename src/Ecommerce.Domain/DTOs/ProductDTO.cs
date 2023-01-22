using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Sku{ get; set; }
        [Required]
        public string Description{ get; set; }
    }
}
