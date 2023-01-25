using System.Collections.Generic;

namespace Ecommerce.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        // TEntity Store(TEntity entity);
    }
}
