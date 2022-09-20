using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoMenuContador
    {
        public string CoUsuario { get; set; } = null!;
        public byte CoMenu { get; set; }
        public sbyte NuPontos { get; set; }
        public byte InProcessado { get; set; }
    }
}
