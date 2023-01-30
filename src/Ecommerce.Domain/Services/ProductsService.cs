using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.DTOs;

namespace Ecommerce.Domain.Services
{
    public class ProductsService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductsService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> List()
        {
            // Console.WriteLine("TESTE VAR");
            // string var1 = Environment.GetEnvironmentVariable("testeVar");

            // Console.WriteLine(var1);

            // Console.WriteLine("MONGO_CONNECTION_STRING");
            // string var2 = Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING");
            // Console.WriteLine(var2);

            // Console.WriteLine("FIM");

            var products = _productRepository.GetAll();

            return products;
        }

        // public Product Create(ProductDTO product) {
        //     // Console.WriteLine("TESTE VAR");
        //     // string var1 = Environment.GetEnvironmentVariable("testeVar");

        //     // Console.WriteLine(var1);

        //     // Console.WriteLine("MONGO_CONNECTION_STRING");
        //     // string var2 = Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING");
        //     // Console.WriteLine(var2);

        //     // Console.WriteLine("FIM");

        //     var product = _productRepository.Store(product);

        //     if (!product) {
        //         return false;
        //     }

        //     return product;
        // }
    }
}
