using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Infra.Context;

namespace Ecommerce.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {

        protected readonly PostgreDbContext _context;

        public Repository(PostgreDbContext context)
        {
            _context = context;
        }


        public virtual IEnumerable<TEntity> GetAll()
        {
            var query = _context.Set<TEntity>();

            if(query.Any())
                return query.ToList();

            return new List<TEntity>();
        }


        // public virtual List<TEntity> GetAll()
        // {
        //     Console.WriteLine("PASSOU POR AQUI - REPOSITORY");
        //     return new List<TEntity>();
        // }

        // public virtual TEntity Store(TEntity product)
        // {
        //     // TEntity saved =
        //     return new List<TEntity>();
        // }
    }
}
