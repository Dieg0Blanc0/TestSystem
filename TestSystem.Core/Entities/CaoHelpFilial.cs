using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoHelpFilial
    {
        public uint CoFilial { get; set; }
        public string NoFilial { get; set; } = null!;
        public int CoCliente { get; set; }
        public string Estado { get; set; } = null!;
    }
}
