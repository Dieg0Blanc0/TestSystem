using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoConhecimentosFonte
    {
        public int Idfonte { get; set; }
        public int Idconhecimento { get; set; }
        public DateTime Datahora { get; set; }
        public string Arquivo { get; set; } = null!;
        public string Caminho { get; set; } = null!;

        public virtual CaoConhecimento IdconhecimentoNavigation { get; set; } = null!;
    }
}
