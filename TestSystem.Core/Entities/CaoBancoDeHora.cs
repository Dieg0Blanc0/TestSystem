using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoBancoDeHora
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; } = null!;
        public DateOnly DataCadastro { get; set; }
        public int Segundos { get; set; }
        public string Tipo { get; set; } = null!;
    }
}
