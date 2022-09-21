using Microsoft.EntityFrameworkCore;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Core.Interfaces.Repositories
{
    public interface ICaoFaturaRepository<TContext> : IBaseRepository<CaoFatura, TContext>
        where TContext : DbContext, new()
    {
        Task<IEnumerable<CaoFatura>> GetAllByCoUsuarioAtRangeDateAsync(string consultor, DateOnly fromDate, DateOnly ToDate, CancellationToken cancellationToken = default);
    }
}
