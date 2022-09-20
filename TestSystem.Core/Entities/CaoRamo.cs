using System;
using System.Collections.Generic;

namespace TestSystem.Core.Entities
{
    /// <summary>
    /// Ramo de atividade de Clientes
    /// </summary>
    public partial class CaoRamo
    {
        public ulong CoRamo { get; set; }
        public string DsRamo { get; set; } = null!;
    }
}
