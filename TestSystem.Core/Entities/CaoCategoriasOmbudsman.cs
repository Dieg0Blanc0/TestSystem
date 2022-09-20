using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoCategoriasOmbudsman
    {
        public CaoCategoriasOmbudsman()
        {
            CaoOmbudsmen = new HashSet<CaoOmbudsman>();
        }

        public sbyte Idcategoria { get; set; }
        public string Descricao { get; set; } = null!;

        public virtual ICollection<CaoOmbudsman> CaoOmbudsmen { get; set; }
    }
}
