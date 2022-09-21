using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Core.DTOs;
using TestSystem.Core.Entities;

namespace TestSystem.Core.Interfaces.Services
{
    public interface ICaoSalarioService
    {
        Task<CaoSalarioDTO> GetByCoUsuarioAsync(string cousuario, CancellationToken cancellationToken = default);
    }
}
