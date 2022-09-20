using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoMovimentoJustificativa
    {
        public ulong CoMovimentoJustificativa { get; set; }
        public ulong CoMovimento { get; set; }
        public ulong NuOs { get; set; }
        public string DsJustificativa { get; set; } = null!;
    }
}
