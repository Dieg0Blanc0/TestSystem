using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    public partial class CaoAgendamento
    {
        public ulong CoAgendamento { get; set; }
        public DateTime DtHrInicio { get; set; }
        public DateTime? DtHrFim { get; set; }
        public long CoStatusAgendamento { get; set; }
        public long CoDiaryReportConsultor { get; set; }
        public long CoComplemento { get; set; }
    }
}
