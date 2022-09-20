using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoCidade
    {
        public ulong CoCidade { get; set; }
        public string NoCidade { get; set; } = null!;
        public long CoUf { get; set; }
    }
}
