using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoConhecimentoUsuario
    {
        public string CoUsuario { get; set; } = null!;
        public uint CoConhecimento { get; set; }
        public uint? NvConhecimento { get; set; }
        public byte? IsCertificado { get; set; }
    }
}
