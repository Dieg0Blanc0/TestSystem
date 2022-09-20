using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Infrastructure.Persistence.Repositories.Base
{
    public class BaseRepository<T, TContext> : IBaseRepository<T, TContext> where T : class where TContext : DbContext, new()
    {
        private TContext _context;
        private readonly DbSet<T> _dbSet;
        protected IDbFactory<TContext> DbFactory { get; private set; }
        protected TContext Context { get => _context ?? (_context = DbFactory.Init()); }
        public BaseRepository(IDbFactory<TContext> dbFactory) { DbFactory = dbFactory; _dbSet = Context.Set<T>(); }

        public async Task AddAsync(T Entity, CancellationToken cancellationToken = default) =>
            await _dbSet.AddAsync(Entity, cancellationToken);


        public void Delete(T Entity) => _dbSet.Remove(Entity);


        public async Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) =>
            await _dbSet.Where(predicate).ToListAsync(cancellationToken);

        public async Task<T> FilterSingleAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) =>
            await _dbSet.Where(predicate).FirstOrDefaultAsync(cancellationToken);

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbSet.ToListAsync(cancellationToken);


        public async Task<T> GetByIdAsync(long id, CancellationToken cancellationToken = default) =>
            await _dbSet.FindAsync(new object[] { id }, cancellationToken);


        public void Update(T Entity) => _dbSet.Update(Entity);
    }
}
