using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_4.Models
{
    internal class PcReparacion : Pc
    {
        public string? Causa { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
