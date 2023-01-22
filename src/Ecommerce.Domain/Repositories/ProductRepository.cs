using System.Collections.Generic;
using System.Linq;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.DTOs;

namespace Ecommerce.Domain.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public override List<Product> GetAll()
        {
            List<Product> list = new List<Product>();

            ProductDTO productDTO_A = new ProductDTO();

            productDTO_A.Id = 1;
            productDTO_A.Name = "Guitarra Tagima T735";
            productDTO_A.Sku = "tg735";
            productDTO_A.Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form.";

            Product productA = new Product(productDTO_A);

            ProductDTO productDTO_B = new ProductDTO();
            
            productDTO_B.Id = 2;
            productDTO_B.Name = "Guitarra PRS SE 245";
            productDTO_B.Sku = "prsse245";
            productDTO_B.Description = "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.";

            Product productB = new Product(productDTO_B);

            ProductDTO productDTO_C = new ProductDTO();
            
            productDTO_C.Id = 3;
            productDTO_C.Name = "Violão Strinberg Folk SD200C";
            productDTO_C.Sku = "stnbgsd200c";
            productDTO_C.Description = "Um violão que combina qualidade, estética e preço justo da marca Strinberg! Pensando nos compradores mais exigentes, a Strinberg criou a linha Black Series de violões.";

            Product productC = new Product(productDTO_C);

            list.Add(productA);
            list.Add(productB);
            list.Add(productC);

            return list;
        }
    }
}
