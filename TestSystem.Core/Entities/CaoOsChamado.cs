using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoOsChamado
    {
        public int CoChamado { get; set; }
        public int CoSistema { get; set; }
        public int CoOs { get; set; }
        public string DsChamado { get; set; } = null!;
        public int CoTipo { get; set; }
        public int CoPrioridade { get; set; }
        public int CoItem { get; set; }
        public string Descricao { get; set; } = null!;
        public string DsSolucao { get; set; } = null!;
        public string Tempo { get; set; } = null!;
        public DateTime DtChamado { get; set; }
        public int Status { get; set; }
        public string CoUsuario { get; set; } = null!;
        public string CoAnalista { get; set; } = null!;
        public string? Email { get; set; }
    }
}
