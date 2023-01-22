using System;
using Ecommerce.Domain.DTOs;

namespace Ecommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product(ProductDTO product)
        {
            Id = product.Id;
            Name = product.Name;
            Sku = product.Sku;
            Description = product.Description;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Sku{ get; private set; }
        public string Description{ get; private set; }
    }
}
