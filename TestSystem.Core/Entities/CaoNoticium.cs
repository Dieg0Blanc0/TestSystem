using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoNoticium
    {
        public int CoNoticia { get; set; }
        public string Assunto { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string Foto { get; set; } = null!;
        public string CoUsuario { get; set; } = null!;
        public DateTime DtNoticia { get; set; }
    }
}
