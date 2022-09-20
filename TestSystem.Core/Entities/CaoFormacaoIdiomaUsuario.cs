using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoFormacaoIdiomaUsuario
    {
        public string CoUsuario { get; set; } = null!;
        public int CoIdioma { get; set; }
        public int? NvLeitura { get; set; }
        public int? NvEscrita { get; set; }
        public int? NvFala { get; set; }
    }
}
