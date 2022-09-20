using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoHelpTelaChamado
    {
        public int CoTela { get; set; }
        public int CoCliente { get; set; }
        public int CoSistema { get; set; }
        public string DsTela { get; set; } = null!;
    }
}
