using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoPagamento
    {
        public ulong CoPagamento { get; set; }
        public string CoUsuario { get; set; } = null!;
        public string TpPagamento { get; set; } = null!;
        public DateOnly DtPagamento { get; set; }
        public float VlPagamento { get; set; }
        public DateOnly DtReferenciaPagamento { get; set; }
    }
}
