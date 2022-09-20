using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoValorDescanso
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; } = null!;
        public string Segundos { get; set; } = null!;
        public string MesReferencia { get; set; } = null!;
    }
}
