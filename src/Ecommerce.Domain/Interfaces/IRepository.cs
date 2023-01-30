namespace Ecommerce.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        // TEntity Store(TEntity entity);
    }
}
