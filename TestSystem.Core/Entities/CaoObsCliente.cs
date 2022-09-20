using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoObsCliente
    {
        public uint CoObs { get; set; }
        public string Descricao { get; set; } = null!;
        public uint CoCliente { get; set; }
        public string? CoUsuario { get; set; }
        public DateTime? DtObs { get; set; }
    }
}
