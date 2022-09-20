using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoSalario
    {
        public string CoUsuario { get; set; } = null!;
        public DateOnly DtAlteracao { get; set; }
        public float BrutSalario { get; set; }
        public float LiqSalario { get; set; }
    }
}
