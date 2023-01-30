using Ecommerce.Domain.DTOs;
namespace Ecommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Sku{ get; private set; }

        public string? Description{ get; private set; }

        public Product(ProductDTO data) {
            Name = data.Name;
            Sku = data.Sku;
            Description = data.Description;
        }
    }
}



// using MongoDB.Bson;
// using MongoDB.Bson.Serialization.Attributes;

// namespace Ecommerce.Domain.Entities;

// public class Product
// {
//     [BsonId]
//     [BsonRepresentation(BsonType.ObjectId)]
//     public string? Id { get; set; }

//     [BsonElement("Name")]
//     public string Name { get; set; } = null!;

//     public decimal Sku { get; set; }

//     public string Description { get; set; } = null!;
// }
