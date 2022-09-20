using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoOsFase
    {
        public int CoFase { get; set; }
        public string? Descricao { get; set; }
        public string DescricaoIngl { get; set; } = null!;
        public int? Ordem { get; set; }
    }
}
