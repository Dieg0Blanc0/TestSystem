using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class TipoUsuario
    {
        public ulong CoTipoUsuario { get; set; }
        public string DsTipoUsuario { get; set; } = null!;
        public ulong CoSistema { get; set; }
    }
}
