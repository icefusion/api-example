using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain.Services
{
    public class ProductsService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductsService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> List()
        {
            var products = _productRepository.GetAll();

            return products;
        }
    }
}
