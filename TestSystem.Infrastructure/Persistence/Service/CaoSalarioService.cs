using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class CaoSalarioService : CRUDService<CaoSalarioDTO, CaoSalarioCreateDTO, CaoSalarioUpdateDTO, CaoSalarioDeleteDTO, CaoSalario, ICaoSalarioRepository<TestSystemDbContext>, TestSystemDbContext>, ICaoSalarioService
    {
        private readonly ICaoSalarioRepository<TestSystemDbContext> _caoSalarioRepository;

        public CaoSalarioService(IMapper mapper, IUnitOfWork<TestSystemDbContext> unitOfWork, ICaoSalarioRepository<TestSystemDbContext> caoSalarioRepository) : base(caoSalarioRepository, unitOfWork, mapper)
        {
            _caoSalarioRepository = caoSalarioRepository;
        }

        public async Task<CaoSalarioDTO> GetByCoUsuarioAsync(string cousuario, CancellationToken cancellationToken = default) =>
            await SingleFilterAsync(x => x.CoUsuario == cousuario, cancellationToken);

    }
}
