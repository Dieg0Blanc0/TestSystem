using Microsoft.EntityFrameworkCore;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Core.Interfaces.Repositories;
using TestSystem.Infrastructure.Persistence.Data;
using TestSystem.Infrastructure.Persistence.Repositories.Base;

namespace TestSystem.Infrastructure.Persistence.Repositories
{
    public class CaoFaturaRepository : BaseRepository<CaoFatura, TestSystemDbContext>, ICaoFaturaRepository<TestSystemDbContext>
    {
        private readonly TestSystemDbContext _context;

        public CaoFaturaRepository(TestSystemDbContext context, IDbFactory<TestSystemDbContext> dbFactory) : base(dbFactory)
        {
            _context = context;
        }

        public async Task<IEnumerable<CaoFatura>> GetAllByCoUsuarioAtRangeDateAsync(string consultor, DateOnly fromDate, DateOnly toDate, CancellationToken cancellationToken = default)
        {
            var result = (from caoFatura in _context.CaoFaturas
                          join caoOs in _context.CaoOs on caoFatura.CoOs equals caoOs.CoOs
                          where caoOs.CoUsuario == consultor && (caoFatura.DataEmissao >= fromDate && caoFatura.DataEmissao <= toDate)
                          select caoFatura);

            return await result.ToListAsync(cancellationToken);
        }
    }
}
