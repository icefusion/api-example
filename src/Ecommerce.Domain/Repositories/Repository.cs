using System.Collections.Generic;
using System.Linq;
using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public virtual List<TEntity> GetAll()
        {
            Console.WriteLine("PASSOU POR AQUI - REPOSITORY");
            return new List<TEntity>();
        }

        // public virtual TEntity Store(TEntity product)
        // {
        //     // TEntity saved =
        //     return new List<TEntity>();
        // }
    }
}
