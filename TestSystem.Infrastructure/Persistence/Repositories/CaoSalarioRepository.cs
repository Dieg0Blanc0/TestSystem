using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Core.Interfaces.Repositories;
using TestSystem.Infrastructure.Persistence.Data;
using TestSystem.Infrastructure.Persistence.Repositories.Base;

namespace TestSystem.Infrastructure.Persistence.Repositories
{
    public class CaoSalarioRepository : BaseRepository<CaoSalario, TestSystemDbContext>, ICaoSalarioRepository<TestSystemDbContext>
    {
        private readonly TestSystemDbContext _context;

        public CaoSalarioRepository(TestSystemDbContext context, IDbFactory<TestSystemDbContext> dbFactory) : base(dbFactory)
        {
            _context = context;
        }

        public async Task<CaoSalario> GetByCoUsuarioAsync(string cousuario, CancellationToken cancellationToken = default) =>
            await FilterSingleAsync(x => x.CoUsuario == cousuario, cancellationToken);
    }
}
