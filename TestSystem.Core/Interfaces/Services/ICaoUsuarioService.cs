using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Core.DTOs;
using TestSystem.Core.Entities;

namespace TestSystem.Core.Interfaces.Services
{
    public interface ICaoUsuarioService
    {
        Task<IEnumerable<CaoUsuarioDTO>> GetAllCaoUsuarioAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<CaoUsuarioDTO>> GetAllCaoUsuarioWithPermisionAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<CaoUsuarioDTO>> FilterCaoUsuariosAsync(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default);
        Task<CaoUsuarioDTO> GetCaoUsuarioByIdAsync(long id, CancellationToken cancellationToken = default);
        Task<CaoUsuarioDTO> SingleFilterCaoUsuarioAsync(Expression<Func<CaoUsuario, bool>> predicate, CancellationToken cancellationToken = default);
        Task<CaoUsuarioCreateDTO> InserCaoUsuarioAsync(CaoUsuarioCreateDTO dto, CancellationToken cancellationToken = default);
        Task<CaoUsuarioUpdateDTO> UpdateCaoUsuarioAsync(CaoUsuarioUpdateDTO dto, CancellationToken cancellationToken = default);
        Task<CaoUsuarioDeleteDTO> DeleteCaoUsuarioAsync(CaoUsuarioDeleteDTO dto, CancellationToken cancellationToken = default);
    }
}
