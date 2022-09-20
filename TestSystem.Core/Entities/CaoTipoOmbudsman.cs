using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoTipoOmbudsman
    {
        public CaoTipoOmbudsman()
        {
            CaoOmbudsmen = new HashSet<CaoOmbudsman>();
        }

        public sbyte Idtipo { get; set; }
        public string Descricao { get; set; } = null!;

        public virtual ICollection<CaoOmbudsman> CaoOmbudsmen { get; set; }
    }
}
