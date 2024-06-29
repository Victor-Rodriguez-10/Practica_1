using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_4.Models
{
    internal class PcNueva : Pc
    {
        public decimal Precio { get; set; }
        public DateTime? FechaIngreso { get; set; } 

        public override void Mostrar()
        {
            Console.WriteLine($" Ram: {Ram},\n Pantalla: {Pantalla},\n Marca: {Marca},\n Modelo: {Modelo},\n Tipo de Sistema: {TipoSistema}, Almacenamiento: {Almacenamiento}\n Precio: {Precio}, Fecha: {FechaIngreso}");
        }
    }

}
