using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_4.Models
{
    internal class Pc
    {
        public int Ram { get; set; }
        public double Pantalla { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? TipoSistema { get; set;}
        public int Almacenamiento { get; set; }


        public virtual void Mostrar()
        {
            Console.WriteLine($" Ram: {Ram},\n Pantalla: {Pantalla},\n Marca: {Marca},\n Modelo: {Modelo},\n Tipo de Sistema: {TipoSistema}, Almacenamiento: {Almacenamiento}\n " );

        }

     

    }

   

    

}
