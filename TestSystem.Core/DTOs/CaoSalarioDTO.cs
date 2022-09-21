using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.Core.DTOs
{
    public class CaoSalarioDTO
    {
        public string CoUsuario { get; set; }
        public DateOnly DtAlteracao { get; set; }
        public float BrutSalario { get; set; }
        public float LiqSalario { get; set; }
    }
}
