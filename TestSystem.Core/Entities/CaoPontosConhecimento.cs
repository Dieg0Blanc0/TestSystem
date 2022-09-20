using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoPontosConhecimento
    {
        public int Idpontos { get; set; }
        public sbyte Pontuacao { get; set; }
        public string CoCoordenador { get; set; } = null!;
        public int Idconhecimento { get; set; }

        public virtual CaoUsuario CoCoordenadorNavigation { get; set; } = null!;
        public virtual CaoConhecimento IdconhecimentoNavigation { get; set; } = null!;
        public virtual CaoEscalaRanking PontuacaoNavigation { get; set; } = null!;
    }
}
