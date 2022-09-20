using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoAtividadeConsultor
    {
        public int CoAtividade { get; set; }
        public string DsAtividade { get; set; } = null!;
        public string? Ativo { get; set; }
    }
}
