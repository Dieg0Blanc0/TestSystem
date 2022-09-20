using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Core.Interfaces.Services.Base
{
    public interface ICrudService<TGetDTO, TAddDTO, TUpdateDTO, TDeleteDTO, TEntity, TRepo, TContext>
        where TEntity : class
        where TRepo : IBaseRepository<TEntity, TContext>
        where TContext : DbContext, new()
    {

        Task<IEnumerable<TGetDTO>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TGetDTO> GetAsync(long id, CancellationToken cancellationToken = default);
        Task<IEnumerable<TGetDTO>> FilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
        Task<TGetDTO> SingleFilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
        Task<TAddDTO> InsertAsync(TAddDTO dto, CancellationToken cancellationToken = default);
        Task<TUpdateDTO> UpdateAsync(TUpdateDTO dto, CancellationToken cancellationToken = default);
        Task<TDeleteDTO> DEleteAsync(TDeleteDTO dto, CancellationToken cancellationToken = default);
    }
}
