using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoFaturaPag
    {
        public int IdFaturaPag { get; set; }
        public int CoFatura { get; set; }
        public DateOnly DtEfetuado { get; set; }
        public float ValorPago { get; set; }
    }
}
