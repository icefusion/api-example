using System.Collections.Generic;

namespace Ecommerce.Domain.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
    }
}
