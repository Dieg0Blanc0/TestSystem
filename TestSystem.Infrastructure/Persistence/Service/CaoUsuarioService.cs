using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Core.DTOs;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Core.Interfaces.Repositories;
using TestSystem.Core.Interfaces.Services;
using TestSystem.Infrastructure.Persistence.Data;
using TestSystem.Infrastructure.Persistence.Service.Base;

namespace TestSystem.Infrastructure.Persistence.Service
{
    public class CaoUsuarioService : CRUDService<CaoUsuarioDTO, CaoUsuarioCreateDTO, CaoUsuarioUpdateDTO, CaoUsuarioDeleteDTO, CaoUsuario, ICaoUsuarioRepository<TestSystemDbContext>, TestSystemDbContext>, ICaoUsuarioService
    {
        private readonly ICaoUsuarioRepository<TestSystemDbContext> _caoUsuarioRepository;

        public CaoUsuarioService(IMapper mapper, IUnitOfWork<TestSystemDbContext> unitOfWork, ICaoUsuarioRepository<TestSystemDbContext> caoUsuarioRepository) : base(caoUsuarioRepository, unitOfWork, mapper)
        {
            _caoUsuarioRepository = caoUsuarioRepository;
        }

        public async Task<CaoUsuarioDeleteDTO> DeleteCaoUsuarioAsync(CaoUsuarioDeleteDTO dto, CancellationToken cancellationToken = default) =>
            await DEleteAsync(dto, cancellationToken);

        public async Task<IEnumerable<CaoUsuarioDTO>> FilterCaoUsuariosAsync(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default) => 
            await FilterAsync(predicate, cancellationToken);

        public async Task<IEnumerable<CaoUsuarioDTO>> GetAllCaoUsuarioAsync(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<IEnumerable<CaoUsuarioDTO>> GetAllCaoUsuarioWithPermisionAsync(CancellationToken cancellationToken = default)
        {
            var list = await _caoUsuarioRepository.GetAllCaoUsuarioWithPermission();

            return _mapper.Map<IEnumerable<CaoUsuarioDTO>>(list); 
        }

        public async Task<CaoUsuarioDTO> GetCaoUsuarioByIdAsync(long id, CancellationToken cancellationToken = default) =>
            await GetAsync(id, cancellationToken);

        public async Task<CaoUsuarioCreateDTO> InserCaoUsuarioAsync(CaoUsuarioCreateDTO dto, CancellationToken cancellationToken = default) =>
            await InsertAsync(dto, cancellationToken);

        public async Task<CaoUsuarioDTO> SingleFilterCaoUsuarioAsync(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default) =>
            await SingleFilterAsync(predicate, cancellationToken);
        
        public async Task<CaoUsuarioUpdateDTO> UpdateCaoUsuarioAsync(CaoUsuarioUpdateDTO dto, CancellationToken cancellationToken = default) =>
            await UpdateAsync(dto, cancellationToken);
    }
}
