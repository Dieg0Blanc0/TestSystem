using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.Core.DTOs
{
    public class PerformanceComercialDTO
    {
        public List<string> Consultors { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }
}
