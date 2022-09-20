using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoDocumentacaoOutro
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public int CoSistema { get; set; }
    }
}
