using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoPermissao
    {
        public string CoUsuario { get; set; } = null!;
        public string PermissaoIntervalo { get; set; } = null!;
        public string PermissaoHoraExtra { get; set; } = null!;

        public virtual CaoUsuario CoUsuarioNavigation { get; set; } = null!;
    }
}
