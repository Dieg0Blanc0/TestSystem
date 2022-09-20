using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoObsSistema
    {
        public uint CoObs { get; set; }
        public string? Descricao { get; set; }
        public long? CoSistema { get; set; }
        public string? CoUsuario { get; set; }
        public DateTime? DtObs { get; set; }
    }
}
