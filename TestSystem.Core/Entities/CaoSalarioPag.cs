using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoSalarioPag
    {
        public int IdPagamento { get; set; }
        public string CoUsuario { get; set; } = null!;
        public DateOnly DtEfetuado { get; set; }
        public string Status { get; set; } = null!;
        public string? Observacao { get; set; }

        public virtual CaoUsuario CoUsuarioNavigation { get; set; } = null!;
    }
}
