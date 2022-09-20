using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoAtividade
    {
        public int CoAtividade { get; set; }
        public string DsAtividade { get; set; } = null!;
        public long CoTipoUsuario { get; set; }
    }
}
