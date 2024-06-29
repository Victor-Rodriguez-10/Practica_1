using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3.Models
{
    internal class Lista
    {
        public int numero { get; set; }
        public int mayor { get; set; }  
        public int menor { get; set; }

        internal object CompareTo(Lista i2)
        {
            throw new NotImplementedException();
        }
    }
}
