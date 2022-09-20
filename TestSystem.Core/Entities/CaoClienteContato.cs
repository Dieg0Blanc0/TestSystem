using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoClienteContato
    {
        public uint CoCliente { get; set; }
        public DateOnly? DtContato { get; set; }
        public uint? FgAgendado { get; set; }
        public TimeOnly? HrIni { get; set; }
        public TimeOnly? HrEnd { get; set; }
    }
}
