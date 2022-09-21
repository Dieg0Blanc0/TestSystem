using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.Core.DTOs
{
    public class CaoFaturaDTO
    {
        public uint CoFatura { get; set; }
        public int CoCliente { get; set; }
        public int CoSistema { get; set; }
        public int CoOs { get; set; }
        public int NumNf { get; set; }
        public float Total { get; set; }
        public float Valor { get; set; }
        public DateOnly DataEmissao { get; set; }
        public string CorpoNf { get; set; } = null!;
        public float ComissaoCn { get; set; }
        public float TotalImpInc { get; set; }
    }
}
