using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoFormacaoUsuario
    {
        public string CoUsuario { get; set; } = null!;
        public string TpCurso { get; set; } = null!;
        public string? DsCurso { get; set; }
        public string? DsInstituicao { get; set; }
        public DateOnly? DtConclusao { get; set; }
    }
}
