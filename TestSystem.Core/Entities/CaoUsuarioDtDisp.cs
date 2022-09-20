using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoUsuarioDtDisp
    {
        public uint CoDtDisp { get; set; }
        public string? CoUsuario { get; set; }
        public DateOnly DtDisp { get; set; }
        public DateOnly DtAlt { get; set; }
    }
}
