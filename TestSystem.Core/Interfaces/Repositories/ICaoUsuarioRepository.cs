using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Core.Interfaces.Repositories
{
    public interface ICaoUsuarioRepository<TContext> : IBaseRepository<CaoUsuario, TContext> where TContext : DbContext, new()
    {
        Task<IEnumerable<CaoUsuario>> GetAllCaoUsuarioAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<CaoUsuario>> FilterCaoUsuariosAsync(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default);
        Task<IEnumerable<CaoUsuario>> GetAllCaoUsuarioWithPermission(CancellationToken cancellationToken = default);
        Task<CaoUsuario> GetCaoUsuarioByIdAsync(long id, CancellationToken cancellationToken = default);
        Task<CaoUsuario> FilterSingleCaoUsuario(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default);
        Task AddCaoUsuarioAsync(CaoUsuario entity, CancellationToken cancellationToken = default);
        void UpdateCaoUsuario(CaoUsuario entity);
        void DeleteCaoUsuario(CaoUsuario entity);
    }
}
