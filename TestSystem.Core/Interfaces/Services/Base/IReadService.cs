using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Core.Interfaces.Services.Base
{
    public interface IReadService<TGetDTO, TEntity, TRepo, TContext>
        where TEntity : class
        where TRepo : IReadRepository<TEntity, TContext>
        where TContext : DbContext, new()
    {
        Task<IEnumerable<TGetDTO>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TGetDTO> GetAsync(long id, CancellationToken cancellationToken = default);
        Task<IEnumerable<TGetDTO>> FilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
        Task<TGetDTO> SingleFilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
