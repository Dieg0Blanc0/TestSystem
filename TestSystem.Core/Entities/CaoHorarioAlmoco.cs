using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoHorarioAlmoco
    {
        public string CoUsuario { get; set; } = null!;
        public string AlmocoSaidaHora { get; set; } = null!;
        public string AlmocoVoltaHora { get; set; } = null!;
    }
}
