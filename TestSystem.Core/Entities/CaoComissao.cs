using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoComissao
    {
        public int CoComissao { get; set; }
        public int CoFatura { get; set; }
        public DateOnly DtEfetuado { get; set; }
    }
}
