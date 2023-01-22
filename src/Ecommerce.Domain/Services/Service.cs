using System.Collections.Generic;
using System.Linq;
using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : BaseEntity
    {
        public List<TEntity> GetAll()
        {
            Console.WriteLine("PASSOU POR AQUI - SERVICE");
            return new List<TEntity>();
        }
    }
}
