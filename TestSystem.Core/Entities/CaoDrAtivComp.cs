using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoDrAtivComp
    {
        public int IdAtivComp { get; set; }
        public string CoUsuario { get; set; } = null!;
        public DateOnly Data { get; set; }
        public string Assunto { get; set; } = null!;
        public TimeOnly TempoGasto { get; set; }
    }
}
