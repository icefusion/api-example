using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Sku{ get; set; }
        
        public string? Description{ get; set; }
    }
}
