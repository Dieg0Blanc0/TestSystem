using Microsoft.EntityFrameworkCore;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Core.Interfaces.Repositories
{
    public interface ICaoSalarioRepository<TContext> : IBaseRepository<CaoSalario, TContext>
        where TContext : DbContext, new()
    {
        Task<CaoSalario> GetByCoUsuarioAsync(string cousuario, CancellationToken cancellationToken = default);
    }
}
