using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Core.Interfaces.Repositories;
using TestSystem.Infrastructure.Persistence.Data;
using TestSystem.Infrastructure.Persistence.Repositories.Base;

namespace TestSystem.Infrastructure.Repositories
{
    public class CaoUsuarioRepository : BaseRepository<CaoUsuario, TestSystemDbContext>, ICaoUsuarioRepository<TestSystemDbContext>
    {
        private readonly TestSystemDbContext _context;

        public CaoUsuarioRepository(TestSystemDbContext context, IDbFactory<TestSystemDbContext> dbFactory) : base(dbFactory)
        {
            _context = context;
        }

        public async Task AddCaoUsuarioAsync(CaoUsuario entity, CancellationToken cancellationToken = default) =>
            await AddAsync(entity, cancellationToken);

        public void DeleteCaoUsuario(CaoUsuario entity) => DeleteCaoUsuario(entity);

        public async Task<IEnumerable<CaoUsuario>> FilterCaoUsuariosAsync(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default) =>
            await FilterAsync(predicate, cancellationToken);

        public async Task<CaoUsuario> FilterSingleCaoUsuario(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default) =>
            await FilterSingleAsync(predicate, cancellationToken);

        public async Task<IEnumerable<CaoUsuario>> GetAllCaoUsuarioAsync(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<IEnumerable<CaoUsuario>> GetAllCaoUsuarioWithPermission(CancellationToken cancellationToken = default)
        {
            var result = (from caoUsuario in _context.CaoUsuarios
                          join permision in _context.PermissaoSistemas on caoUsuario.CoUsuario equals permision.CoUsuario
                          where permision.CoSistema == 1 && permision.InAtivo == "S" && (permision.CoTipoUsuario == 0 || permision.CoTipoUsuario == 1 || permision.CoTipoUsuario == 2)
                          select caoUsuario);

            return await result.ToListAsync(cancellationToken);
        }

        public async Task<CaoUsuario> GetCaoUsuarioByIdAsync(long id, CancellationToken cancellationToken = default) =>
            await GetByIdAsync(id, cancellationToken);

        public void UpdateCaoUsuario(CaoUsuario entity) => UpdateCaoUsuario(entity);
    }
}
