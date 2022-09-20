using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoBonusStatus
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; } = null!;
        public DateOnly DataSolic { get; set; }
        public string Mes { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string? IsSolic { get; set; }
        public string? IsPg { get; set; }
        public string? IsHoras { get; set; }
    }
}
